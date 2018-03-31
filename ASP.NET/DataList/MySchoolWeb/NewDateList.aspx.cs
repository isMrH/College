using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;
using MySchool.Model;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dlNews.DataSource = NewsManager.GetAllNews();
            dlNews.DataBind();
        }
    }
    protected void btnSort_Click(object sender, EventArgs e)
    {
   
    }
    public int page
    {
        get { return Convert.ToInt32(ViewState["page"]); }

        set { ViewState["page"] = value; }
    }
    public string order
    {
        get { return ViewState["order"].ToString(); }
        set { ViewState["order"] = value; }
    }
    private void DisplayNews(string order)
    {
        PagedDataSource pdsNews = new PagedDataSource();
        pdsNews.DataSource = NewsManager.GetAllNews(order);

        pdsNews.AllowPaging = true;
        pdsNews.PageSize = 3;
        pdsNews.CurrentPageIndex = page;

        if(pdsNews.IsFirstPage)
            btn
    }
}
