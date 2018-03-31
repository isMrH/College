using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtUname.Text.Trim() == "")
        {
            lblMessage.Text = "用户名或密码不能为空！";
        }
        else if(txtUname.Text.Trim()=="admin"&&txtPwd.Text.Trim()=="admin")
        {
            lblMessage.Text=txtUname.Text+",欢迎您你！";
        }
        else
        {
            lblMessage.Text="用户名或密码错误！";
        }


    }
}
