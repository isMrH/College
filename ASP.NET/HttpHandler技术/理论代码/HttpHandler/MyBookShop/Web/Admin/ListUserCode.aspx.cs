using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;

public partial class Admin_ListUserCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gvDataBound();
    }
    private void gvDataBound()
    {
        this.gvMain.DataSource = UserManager.GetAllNormalUsers();
        this.gvMain.DataBind();
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
            Response.Redirect("UserDetails.aspx?Id=" + e.CommandArgument.ToString());
        }
    }
}
