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
using MyBookManager.BLL;


public partial class BookList : System.Web.UI.Page
{
    BookManager bm = new BookManager();
    protected void Page_Load(object sender, EventArgs e)
    {        
        if (!IsPostBack)
        {
            //页面加载时显示全部图书信息
            ViewState["Page"] = 0;//默认为第一页
            ViewState["Order"] = "";//默认显示全部
            try
            {
                //接到从列表页传过来的类型
                ViewState["typeid"] = Convert.ToInt32(Request.QueryString["typeid"]);
            }
            catch
            {
                ViewState["typeid"] = -1;
            }
            //绑定数据
            Databind();
        }     
    }
        
    private void Databind()
    {
        PagedDataSource pdsBooks = new PagedDataSource();
        //对PagedDataSource 对象的相关属性赋值        
        pdsBooks.DataSource = bm.GetBooksByTypeid(Convert.ToInt32(ViewState["typeid"]), (string)ViewState["Order"]);
        //设置为允许分页
        pdsBooks.AllowPaging = true;
        //每页存放四本书
        pdsBooks.PageSize = 4;
        pdsBooks.CurrentPageIndex = Pager;
        //显示共几页和当前页
        lblCurrentPage.Text = "第 " + (pdsBooks.CurrentPageIndex + 1).ToString() + " 页 共 " + pdsBooks.PageCount.ToString()+" 页";
        //调用翻页函数
        SetEnable(pdsBooks);        

        //把PagedDataSource 对象赋给DataList控件 
        dlBooks.DataSource = pdsBooks;
        dlBooks.DataBind();
    }
  
    // 获得封面的url
  
    public string GetUrl(string isbn)
    {
        //调用函数
        return StringHandler.CoverUrl(isbn);
    }
    
    // 截断图书显示内容
   
    public string GetCut(string content, int num)
    {
        //截串
        return StringHandler.CutString(content, num);
    }


    //  排序
    protected void btnDate_Click(object sender, EventArgs e)
    {
        //按照出版日期排序
        ViewState["Order"] = "PublishDate";
        Pager = 0;
        btnDate.Enabled = false;
        btnPrice.Enabled = true;
        Databind();
    }
    //排序
    protected void btnPrice_Click(object sender, EventArgs e)
    {
        //按照单价排序
        ViewState["Order"] = "UnitPrice";
        Pager = 0;
        btnPrice.Enabled = false;
        btnDate.Enabled = true;
        Databind();
    }



    //  翻页
    private void SetEnable(PagedDataSource pds)
    {
        btnPrev.Enabled = true;
        btnNext.Enabled = true;
        if (pds.IsFirstPage)
            btnPrev.Enabled = false;

        if (pds.IsLastPage)
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
    
}
