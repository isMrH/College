using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 上机3任务3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPwd.Text == "admin")
            {
                HttpCookie UserName = new HttpCookie("userName", txtName.Text);
                UserName.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(UserName);
                HttpCookie LoginDate = new HttpCookie("LoginDate", DateTime.Now.ToShortDateString());
                LoginDate.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(LoginDate);
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或密码错误！');</script>");
            }
        }
    }
}
