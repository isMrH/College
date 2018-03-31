using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlog.BLL;
using MyBlog.Model;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd0_Click(object sender, ImageClickEventArgs e)
    {
        string LoginId = txtUname.Text.Trim();
        //判断非空
        if (txtUname.Text == "" || txtAPWD.Text== "" || txtNName.Text == "" || txtRePwd.Text == "" || txtQQ.Text == "" || txtEmail.Text == "")
        {
            lblErr.Text = "请输入完整信息！";
            return;
        }
        User user = new User();
        user.LoginId = LoginId;
        user.LoginPwd = txtRePwd.Text;
        user.Name = txtUname.Text;
        user.QQ =Convert.ToInt32(txtQQ.Text);
        user.Mail = txtEmail.Text;
        //判断两次密码是否一致
        if (txtAPWD.Text == txtRePwd.Text)
        {
            int cnt = Convert.ToInt32(UserManagers.GetUsersName(LoginId));
            if (cnt > 0)
            {
                lblErr.Text = "存在同名账户！";
            }
            else
            {
                int cmt = UserManagers.insertUser(user);
                if (cmt > 0)
                {
                    lblErr.Text = "注册成功！";
                }
                else
                {
                    lblErr.Text = "注册失败！";
                }


            }
        }
        else
        {
            lblErr.Text = "两次输入密码不一致！";
        }
    }
}
