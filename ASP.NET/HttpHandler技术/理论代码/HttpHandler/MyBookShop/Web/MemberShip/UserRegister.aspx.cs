using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;
using MyBookShop.Models;

public partial class UserRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            snCode.Create();
        }
    }


    protected void btnReset_Click(object sender, EventArgs e)
    {
        this.txt_LoginId.Text = String.Empty;
        this.txt_LoginPwd.Text = String.Empty;
        this.txt_Name.Text = String.Empty;
        this.txt_Address.Text = String.Empty;
        this.txt_Tele.Text = String.Empty;
        this.txt_Email.Text = String.Empty;
    }

    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        if (!CeckCode())
        {
            this.ltMain.Text = "<script>alert('验证码错误！')</script>";
            return;
        }
        User user = new User();
        user.LoginId = this.txt_LoginId.Text;
        user.LoginPwd = this.txt_LoginPwd.Text;
        user.Name = this.txt_Name.Text;
        user.Address = this.txt_Address.Text;
        user.Phone = this.txt_Tele.Text;
        user.Mail = this.txt_Email.Text;
        
        if (UserManager.LoginIdExists(user.LoginId))
        {
            this.ltMain.Text = "<script>alert('用户名已使用！请重新选择！')</script>";
        }
        UserManager.AddUser(user);
        this.ltMain.Text = "<script>alert('注册成功！请继续购物');window.location='../BookList.aspx'</script>";
    }
    protected bool CeckCode()
    {
        if (snCode.CheckSN(tbCode.Text.Trim()))
        {
            return true;
        }
        else
        {
            snCode.Create();
            return false;
        }
    }
}
