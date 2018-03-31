using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBookManager.BLL;

public partial class OnLine : System.Web.UI.Page
{
    UserManager um = new UserManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = um.GetOnLine();
            GridView1.DataBind();
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        GridView1.DataSource = um.GetOnLine();
        GridView1.DataBind();
    }
}
