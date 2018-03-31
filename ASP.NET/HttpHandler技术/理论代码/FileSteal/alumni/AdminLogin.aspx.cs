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

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if ((txtName.Text.Trim()) == "" || (txtName.Text == null))
        {
            Response.Write("请输入用户名");


        }
        else
        {
            if (txtPsd.Text == "" || (txtPsd.Text == null))
            {
                Response.Write("请输入密码");
            }
            else
            {
                if (txtName.Text.Trim() == "administrator" && txtPsd.Text == "password")
                {
                    UserInfo userInfo = new UserInfo();

                    userInfo.UserName = txtName.Text;
                    userInfo.PassWord = txtPsd.Text;
                    Session["userInfo"] = userInfo;
                    Session.Timeout = 10;

                    Response.Redirect("ManagePage.aspx");

                }
                else
                {
                    Response.Write("您的用户名或密码错误！");
                }


            }
        }






    }
}
