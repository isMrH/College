using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlog.BLL;
using MyBlog.Model;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        string Name = txtName.Text.Trim();
        string Pwd = txtPwd.Text.Trim();
        if (Name == "" || Pwd == "")
        {
            lblError.Text = "用户名和密码不能为空！";
            return;
        }        
        User user = new User();
        user.Name = Name;
        user.LoginPwd = Pwd;
        int cnt = Convert.ToInt32(UserManagers.IsRegisteUser(Name, Pwd));
        if (cnt > 0)
        {
            PanLogin.Visible = false;
            PanLoginMes.Visible = true;
            lblMes.Text ="欢迎" + txtName.Text + "登录";
            
        }
        else
        {
            lblError.Text = "账号或密码错误!";
        }
        
    }
    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Add.aspx");
    }
}
