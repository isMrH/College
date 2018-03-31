using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBookManager.BLL;
using MyBook.Model;

public partial class Login : System.Web.UI.Page
{
    UserManager um = new UserManager();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        //取得登录名
        string id = txtLoginId.Text.Trim();
        //取得登录密码
        string pwd = txtLoginPwd.Text.Trim();
        //验证是否登录成功
        int res = um.LoginUser(id, pwd);
        if (res > 0)
        {
            //如果登录成功，则实例化用户类
            User LoginUser = new User();
            LoginUser.LoginId = id;
            LoginUser.LoginPwd = pwd;
            //将用户信息存在session中
            Session["LoginUser"] = LoginUser;
            //跳到图书列表页
            Response.Redirect("BookList.aspx");
        }
        else
        {
            //提示输入错误
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或密码输入错误！！')</script>");
            
        }
    }
    protected void btnRegister_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}
