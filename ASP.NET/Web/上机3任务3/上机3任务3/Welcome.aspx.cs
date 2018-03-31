using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 上机3任务3
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserName"] != null)
            {
                lblMes.Text = "欢迎" + Request.Cookies["UserName"].Value + "<br>";
            }
            if (Request.Cookies["LoginDate"] != null)
            {
                lblMes.Text += "您的登录时间为：" + Request.Cookies["LoginDate"].Value;
            }
        }
    }
}
