using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;

public partial class NewsWeb : System.Web.UI.Page
{
    public int page
    {
        get { return Convert.ToInt32(ViewState["page"]); }
        set { ViewState["page"] = value; }
    }
    public string  order
    {
        get { return ViewState["order"].ToString(); }
        set { ViewState["order"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            order = "";
            DisplayNews(order);
        }
    }

    private void DisplayNews(string order)
    {
        //为PageDataSource配置需要分页的数据源
        PagedDataSource pdsNews = new PagedDataSource();
        pdsNews.DataSource = NewsManager.GetAllNews(order);

        //设置PageDataSource类的属性完成分页
        pdsNews.AllowPaging = true;
        pdsNews.PageSize = 3;
        pdsNews.CurrentPageIndex = page;

        //根据是否是第一页和最后一页，控制页面按钮的显示
        if (pdsNews.IsFirstPage)
        {
            btnPrev.Enabled = false;
        }
        else if (pdsNews.IsLastPage)
        {
            btnNext.Enabled = false;
        }
        else
        {
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }
        lblMesage.Text = "当前是第" + (pdsNews.CurrentPageIndex + 1).ToString() + "页 共" + pdsNews.PageCount.ToString() + "页";
        dlNews.DataSource = pdsNews;
        dlNews.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        order = "PublishDate";
        DisplayNews(order);
    }
    protected void btnPrev_Click(object sender, EventArgs e)
    {
        page--;
        DisplayNews(order);
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        page++;
        DisplayNews(order);
    }
}
