using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;

public partial class RepeaterNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            repNews.DataSource = NewsManager.GetAllNews();
            repNews.DataBind();    
        }
    }
}
