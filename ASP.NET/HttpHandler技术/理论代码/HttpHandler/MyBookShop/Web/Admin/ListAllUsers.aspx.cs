using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;
using MyBookShop.Models;

public partial class _ListAllUsers : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnAllUsers_Click(object sender, EventArgs e)
    {
        gvMain.DataSourceID = "objdsUsers";
    }
    protected void btnNormalUsers_Click(object sender, EventArgs e)
    {
        gvMain.DataSourceID = "objdsNormalUsers";
    }

    protected void gvMain_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lb = e.Row.FindControl("linb_Delete") as LinkButton;
            lb.Attributes.Add("onclick", "return confirm('确认删除吗？')");
        }
    }

    protected void gvMain_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "View")
        {
            Response.Redirect("UserDetails.aspx?Id="+e.CommandArgument.ToString());
        }
    }
}
