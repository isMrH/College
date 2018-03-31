using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlog.BLL;
using MyBlog.Model;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd0_Click(object sender, ImageClickEventArgs e)
    {
        if (Page.IsValid)
        {
            string LoginId = txtUname.Text.Trim();
            User user = new User();
            user.LoginId = LoginId;
            user.LoginPwd = txtRePwd.Text;
            user.Name = txtUname.Text;
            user.QQ = Convert.ToInt32(txtQQ.Text);
            user.Mail = txtEmail.Text;
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {        
        if (txtQQ.Text.Length >= 5 && txtQQ.Text.Length <= 10)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
}
