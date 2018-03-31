using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 上机3任务1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.PreviousPage != null)
            {
                TextBox txtName = this.PreviousPage.FindControl("txtName") as TextBox;
                if (txtName != null)
                {
                    lblName.Text = txtName.Text;
                }
                DropDownList ddlTrade = this.PreviousPage.FindControl("ddlTrade") as DropDownList;
                if (ddlTrade != null)
                    lblTrade.Text = ddlTrade.SelectedValue;
                DropDownList ddlQuality = this.PreviousPage.FindControl("ddlQuality") as DropDownList;
                if (ddlQuality != null)
                    lblQuality.Text = ddlQuality.SelectedValue;

                TextBox txtFinancing = this.PreviousPage.FindControl("txtFinancing") as TextBox;
                if (txtFinancing != null)
                {
                    lblFinancing.Text = txtFinancing.Text;
                }

                TextBox txtAddress = this.PreviousPage.FindControl("txtAddress") as TextBox;
                if (txtAddress != null)
                {
                    lblAddress.Text = txtAddress.Text;
                }
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('企业会员信息录入成功！')</script>");
        }
    }
}
