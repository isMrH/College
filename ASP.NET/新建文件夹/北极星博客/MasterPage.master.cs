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
        string name = txtName.Text;
        string pwd = txtPwd.Text;
        Users user = new Users();
        user.Name = name;
        user.LoginPwd = pwd;
        int cnt = Convert.ToInt32(UsersManager.IsRegisteUser(name, pwd));
        if (cnt > 0)
        {
            Response.Write("已存在同名账户，请重新选择！");
        }
        else
        {

 
        }
    }
    protected void btnEnter_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string pwd = txtPwd.Text;
        Users user = new Users();
        user.Name = name;
        user.LoginPwd = pwd;
        int cnt = Convert.ToInt32(UsersManager.IsRegisteUser(name, pwd));
        if (cnt > 0)
        {
            Response.Write("登录成功！");
        }
        else
        {
            Response.Write("登录失败！");
        }

    }
}
