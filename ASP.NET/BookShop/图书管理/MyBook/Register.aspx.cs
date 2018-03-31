using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBookManager.BLL;
using MyBook.Model;

public partial class Register : System.Web.UI.Page
{
    UserManager um = new UserManager();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtLoginId_TextChanged(object sender, EventArgs e)
    {
        string loginid = txtLoginId.Text.Trim();
        int res = um.IsHasInfo(loginid);
        if (res > 0)
        {
            lblMessage.Text = "用户名已存在！";
        }
    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (txtLoginPwd.Text == txtPwd1.Text)
        {
            User user = new User();
            user.LoginId = txtLoginId.Text;
            user.LoginPwd = txtLoginPwd.Text;
            int cnt = um.AddInfo(user);
            if (cnt > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功！！')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册失败！！')</script>");
            }
        }
    }
    protected void btnRegister_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
