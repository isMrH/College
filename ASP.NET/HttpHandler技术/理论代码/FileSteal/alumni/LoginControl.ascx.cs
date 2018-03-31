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

public partial class LoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            snValidate.Create();
        }


    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if ((txtName.Text.Trim()) == "" || (txtName.Text == null))
        {
            Response.Write("请输入姓名");


        }
        else
        {
            if (txtPsd.Text == "" || (txtPsd.Text == null))
            {
                Response.Write("请输入密码");
            }
            else if (txtValidate.Text == "" || txtValidate.Text == null)
            {
                Response.Write("请输入验证码");
            }
            else
            {
                if (txtName.Text.Trim() == "恰嬉猫" && txtPsd.Text == "123456" && snValidate.CheckSN(txtValidate.Text.Trim()))
                {
                    UserInfo userInfo = new UserInfo();

                    userInfo.UserName = txtName.Text;
                    userInfo.PassWord = txtPsd.Text;
                    Session["userInfo"] = userInfo;
                    Session.Timeout = 10;

                    Response.Redirect("Welcome.aspx");

                }
                else
                {
                    Response.Write("您的用户名或密码错误！");
                    snValidate.Create();


                }


            }
        }
        
        
        
        
        
    }
    protected void lnkbtnAgain_Click(object sender, EventArgs e)
    {
        snValidate.Create();
    }
}
