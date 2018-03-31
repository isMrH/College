using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myBlog.BLL;
using myBlog.Model;


public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnEnter_Click(object sender, EventArgs e)
    {
        
    }
    protected void IBtnEnter0_Click(object sender, ImageClickEventArgs e)
    {
        string name = txtName.Text;
        string pwd = txtPwd.Text;
        //判断非空
        if (txtPwd.Text == "" || txtName.Text == "")
        {
            Response.Write("用户名和密码不能为空！");
        }
        Users user = new Users();
        user.Name = name;
        user.LoginPwd = pwd;
        int cnt = Convert.ToInt32(UsersManager.IsRegisteUser(name, pwd));
        if (cnt > 0)
        {
            this.Panel3.Visible = true;
            this.Panel4.Visible = false;
            lblMes.Text = name + "欢迎您！";
        }
        else
        {
            lblMessage.Text = "登录失败!";
        }
    }
    protected void IBtnSubmit0_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/show.aspx");//跳转页面

    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        this.Panel3.Visible = false;
        this.Panel4.Visible = true;

    }
}
