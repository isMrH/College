using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["title"] != null)
        {
            ((Label)this.Master.FindControl("lblName")).Text = ">>" + Request.QueryString["title"];
            lblMes.Text = "<h1>欢迎你访问" + Request.QueryString["title"] + "</h1>";
        }
    }
}
