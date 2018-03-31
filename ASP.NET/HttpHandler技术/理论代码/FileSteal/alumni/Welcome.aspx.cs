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

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            UserInfo userInfo = Session["userInfo"] as UserInfo;
            lblNowTime.Text = DateTime.Now.ToString();

            if ((userInfo == null))
            {
                Response.Redirect("Login.aspx");
            }
            else if ((userInfo.UserName != "恰嬉猫") || (userInfo.PassWord != "123456"))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblWelcome.Text = userInfo.UserName ;
            }

            HttpCookie userCookie = new HttpCookie("userCookie");
            userCookie.Values["userName"] = userInfo.UserName.ToString();
            userCookie.Values["lastVist"] = DateTime.Now.ToString();
            userCookie.Expires = DateTime.Now.AddDays(30);


            Response.Cookies.Add(userCookie);


        }
  

    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if ((txtTitle.Text.Trim()) == "" || (txtTitle.Text == null))
        {
            lblMessage.Text = "请输入标题！";


        }
        else
        {
            if (txtContent.Text == "" || (txtContent.Text == null))
            {
                lblMessage.Text = "请输入新闻内容";
            }


            else
            {
                lblTitle.Text = txtTitle.Text;
                lblMessage.Text = txtContent.Text;
                
            }
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtTitle.Text = "";

        txtContent.Text = "";

        lblMessage.Text = "";
    }
}
