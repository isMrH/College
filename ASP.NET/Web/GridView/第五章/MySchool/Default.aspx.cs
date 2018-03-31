using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string Cut(object obj)
    {
        string str = obj.ToString();
        if (str.Length > 30)
        {
            return str.Substring(0, 30) + "......";
        }
        else
        {
            return str;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDel")
        {
            Response.Redirect("show.aspx?id=" + e.CommandArgument);
        }
    }
}
