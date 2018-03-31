using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;

public partial class NewsWeb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dlNews.DataSource = NewsManager.GetAllNews();
        dlNews.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        dlNews.DataSource = NewsManager.GetAllNews("publishdate");
        dlNews.DataBind();
    }
}
