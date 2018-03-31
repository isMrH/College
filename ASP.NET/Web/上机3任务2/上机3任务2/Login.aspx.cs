using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 上机3任务2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPwd.Text == "admin")
            {
                User user = new User();
                user.UserName = txtName.Text;
                user.Password = txtPwd.Text;
                Session["user"] = user;
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或密码错误！');</script>");
            }
        }

    }
}
