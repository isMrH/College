using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Users.BLL;
using Users.Model;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        User u = new User();
        try
        {
            u.LoginID = txtUName.Text.Trim();
            u.LoginPwd = txtPWD.Text.Trim();
            u.Name = txtName.Text.Trim();
            u.QQ = int.Parse(txtQQ.Text.Trim());
            u.Email = txtEmail.Text.Trim();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('请输入正确数据！')</script>");
            return;
        }
        if (u.LoginID == "" || u.LoginPwd == "" || u.Name == "" || u.QQ < 1 || u.Email == "")
        {
            Response.Write("<script>alert('所有数据不能为空！')</script>");
        }
        else
        {
            string ReLoginPwd = txtRePWD.Text.Trim();
            if (u.LoginPwd != ReLoginPwd)
            {
                Response.Write("<script>alert('两次密码不一致请重新输入！')</script>");
            }
            else
            {

                int obj = Convert.ToInt32(UsersManager.GetScaler(u.LoginID));
                if (obj > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户已使用！请重新选择！')</script>");
                }
                else
                {


                    int cnt = UsersManager.InsertUser(u);
                    if (cnt > 0)
                    {
                        Response.Write("<script>alert('注册成功，新新博客欢迎您！')</script>");
                    }
                }
            }
        }
    }
}
