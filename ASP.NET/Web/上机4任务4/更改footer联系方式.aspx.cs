using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 更改footer联系方式 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label lblTel = (Label)this.Master.FindControl("lblTel");
        if (lblTel != null)
        {
            lblTel.Text = "0311-98765432";
        }
    }
}
