using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Myblog.Model;
using MyBlogBLL;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, ImageClickEventArgs e)
    {
        User user = new User();
        user.LoginId = this.txtLoginId.Text;
        user.LoginPwd = this.txtLoginPwd.Text;
        user.Name = this.txtName.Text;
        user.QQ = this.txtQQ.Text;
        user.Mail = this.txtEmail.Text;

         UserManager.Register(user);      
         ClientScript .RegisterStartupScript (this.GetType (),"","<script>alert('注册成功！北极星博客欢迎您！');window.location='Login.aspx'</script>");
       

    }
}
