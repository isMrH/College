using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogBLL;
using MyBlogModels;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void imgbtnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (UserManager.Login(txtLoginId.Text, txtLoginPwd.Text))
        {

            Session["CurrentUser"] = txtLoginId.Text;

            Response.Redirect("~/Default.aspx");
        }
        else
        {
            Response.Write("<script>alert('用户名或密码不正确，请重新填写')</script>");
        }
    }
    protected void imgbtnRegister_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}
