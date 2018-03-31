using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myBlog.Model;
using myBlog.BLL;

public partial class show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void IBtnAchieve_Click(object sender, ImageClickEventArgs e)
    {
        string loginid = txtUserName.Text;
        //判断非空
        if (txtUserName.Text == "" || txtPwd.Text == "" || txtName.Text == "" || txtTruePwd.Text == "" || txtQQ.Text == "" || txtEmail.Text == "")
        {
            lblMess.Text = "请输入完整信息！";
        }
        Users user = new Users();
        user.LoginId = loginid;
        user.LoginPwd = txtTruePwd.Text;
        user.Name = txtName.Text;
        user.Qq = txtQQ.Text;
        user.Mail = txtEmail.Text;
        //判断两次密码是否一致
        if (txtPwd.Text == txtTruePwd.Text)
        {
            int cnt = Convert.ToInt32(UsersManager.GetUsersName(loginid));
            if (cnt > 0)
            {
                lblMess.Text = "存在同名账户！";
            }
            else
            {
                int cmt = UsersManager.insertUser(user);
                if (cmt > 0)
                {
                    lblMess.Text = "注册成功！";
                }
                else
                {
                    lblMess.Text = "注册失败！";
                }


            }
        }
        else
        {
            lblMess.Text = "两次输入密码不一致！";
        }
        
    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
}
