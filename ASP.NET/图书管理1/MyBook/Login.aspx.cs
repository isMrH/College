using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBook.Model;
using MyBookManager.BLL;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Users u= UserManager.GetUsersByID(txtUser.Text);
        if (u.username == txtUser.Text && u.userpassword == txtPwd.Text)
        {
            Users us = new Users();
            us.username = txtUser.Text;
            us.userpassword = txtPwd.Text;
            Session["us"] = us;
            Response.Redirect("BookList.aspx");
        }
        else 
        {
           Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('账号或密码错误！')</script>");
        }
    }
}
