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

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void imgb_Sure_Click(object sender, ImageClickEventArgs e)
    {
        User user;
        if (UserManager.AdminLogin(this.txt_LoginId.Text, this.txt_LoginPwd.Text, out user))
        {
            Session["AdminUser"] = user;
            #region 旧代码
            //FormsAuthenticationTicket tkt;
            //string cookiestr;
            //HttpCookie ck;
            //tkt = new FormsAuthenticationTicket(1, user.Name, DateTime.Now, DateTime.Now.AddMinutes(30), true, "your custom data"); //创建一个验证票据
            //cookiestr=FormsAuthentication.Encrypt(tkt);//并且加密票据
            //ck=new HttpCookie(FormsAuthentication.FormsCookieName,cookiestr);// 创建cookie
            //ck.Path=FormsAuthentication.FormsCookiePath;//cookie存放路径
            //Response.Cookies.Add(ck);
            #endregion
            string strRedirect;
            strRedirect = Request["ReturnUrl"];

            System.Web.Security.FormsAuthentication.SetAuthCookie(user.Name, true);
            if(strRedirect==null)
                Response.Redirect("~/Admin/ListAllUsers.aspx");
            Response.Redirect(strRedirect);
        }
        else
        {
            Response.Redirect("~/Error.aspx");
        }
        
    }

    protected void imgb_Cancel_Click(object sender, ImageClickEventArgs e)
    {
        this.txt_LoginId.Text = String.Empty;
        this.txt_LoginPwd.Text = String.Empty;
    }
}
