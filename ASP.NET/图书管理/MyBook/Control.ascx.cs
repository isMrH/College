using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string isbn = txtsearch.Text.Trim().ToString();
        Response.Redirect("bookshow.aspx?isbn=" + isbn);
    }
}
