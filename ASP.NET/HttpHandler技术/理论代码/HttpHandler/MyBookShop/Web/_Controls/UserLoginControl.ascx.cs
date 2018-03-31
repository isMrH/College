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

public partial class _Controls_UserLoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CurrentUser"] != null)
            {
                this.tbl_first.Visible = false;
                this.tbl_secend.Visible = false;
                this.link_Exit.Visible = true;
            }
        }
    }    

    protected void btn_Register_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("../Membership/UserRegister.aspx");
    }

    protected void btn_Login_Click1(object sender, ImageClickEventArgs e)
    {
        User user;
        if (UserManager.Login(this.txt_LoginId.Text, this.txt_LoginPwd.Text, out user))
        {
            Session["CurrentUser"] = user;
            Response.Redirect("~/BookList.aspx");
        }
        else
        {
            Response.Write("<script>alert('用户名或密码不正确，请重新填写')</script>");
        }
    }
}