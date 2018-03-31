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
using MyBookShop.Models;
using System.Text;

public partial class Books_ListOfBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Sure_Click(object sender, EventArgs e)
    {
        string sb = String.Empty;
        for (int i = 0; i < this.grv_Books.Rows.Count; i++)
        {
            CheckBox cb = (grv_Books.Rows[i].FindControl("chb_Select")) as CheckBox;
            if (cb.Checked == true)
            {
                sb += (grv_Books.Rows[i].FindControl("lbl_Id") as Label).Text + ",";
            }
        }
    }

    public string GetCategary(object Categary)
    {
        return ((Category)Categary).Name;
    }
    protected void grv_Books_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor");
        }
    }
}
