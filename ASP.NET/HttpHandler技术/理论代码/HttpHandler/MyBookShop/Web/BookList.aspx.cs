using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;


public partial class BookList : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {        
        if (!IsPostBack)
        {
            //首次加载，赋初值
            ViewState["Page"] = 0;
            ViewState["Order"] = "";
            try
            {
                ViewState["typeid"] = Convert.ToInt32(Request.QueryString["typeid"]);
            }
            catch
            {
                ViewState["typeid"] = -1;
            }
            Databind();
        }     
    }
        
    private void Databind()
    {
        PagedDataSource objPds = new PagedDataSource();
        //对PagedDataSource 对象的相关属性赋值        
        objPds.DataSource = BookManager.GetSmallBooks(Convert.ToInt32(ViewState["typeid"]), (string)ViewState["Order"]);
        objPds.AllowPaging = true;
        objPds.PageSize = 4;

        objPds.CurrentPageIndex = Pager;
        lblCurrentPage.Text = "第 " + (objPds.CurrentPageIndex + 1).ToString() + " 页 共 " + objPds.PageCount.ToString()+" 页";
        SetEnable(objPds);        

        //把PagedDataSource 对象赋给DataList控件 
        dl_Books.DataSource = objPds;
        dl_Books.DataBind();
    }

    public string GetUrl(string isbn)
    {
        return StringHandler.CoverUrl(isbn);
    }
    public string GetCut(string content, int num)
    {
        return StringHandler.CutString(content, num);
    }


    #region  排序
    protected void btnDate_Click(object sender, EventArgs e)
    {
        ViewState["Order"] = "PublishDate";
        Pager = 0;
        btnDate.Enabled = false;
        btnPrice.Enabled = true;
        Databind();
    }
    protected void btnPrice_Click(object sender, EventArgs e)
    {
        ViewState["Order"] = "UnitPrice";
        Pager = 0;
        btnPrice.Enabled = false;
        btnDate.Enabled = true;
        Databind();
    }
    #endregion



    #region  翻页
    private void SetEnable(PagedDataSource objPds)
    {
        btnPrev.Enabled = true;
        btnNext.Enabled = true;
        if (objPds.IsFirstPage)
            btnPrev.Enabled = false;

        if (objPds.IsLastPage)
            btnNext.Enabled = false;
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        Pager++;
        Databind();
    }
    protected void btnPrev_Click(object sender, EventArgs e)
    {
        Pager--;
        Databind();
    }
    /// <summary>
    /// 当前页数
    /// </summary>
    private int Pager
    {
        get
        {
            return (int)ViewState["Page"];
        }
        set
        {
            ViewState["Page"] = value;
        }
    }
    #endregion

    protected void dl_Books_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
