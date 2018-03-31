using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthTypeItemDB.BLL;
using HealthTypeItemDB.Medol;


public partial class healthList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            display();
           
        }
    }
    public void display()
    {
        gvlist.DataSource = HealthItemListManager.GetAllHealthItemList();
        gvlist.DataBind();
    }
    protected void gvlist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvlist_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvlist.PageIndex = e.NewPageIndex;
        display();
    }
    protected void gvlist_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "upd")
        {
            Response.Redirect("update.aspx?ItemListld=" + id);
        }
    }
    
   
}
