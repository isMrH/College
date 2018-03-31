using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 上机3任务2
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                User user=Session["user"] as User;
                Response.Write("欢迎您" + user.UserName);
                Response.Write("<br/>网站总访问量为：" + Application["total"].ToString());
                Response.Write("<br/>当前在线人数为：" + Application["online"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
          
        }

        protected void lbtnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
