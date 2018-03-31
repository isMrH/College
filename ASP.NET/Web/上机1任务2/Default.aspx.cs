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
        lblTime.Text = DateTime.Now.ToString();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtTitle.Text.Trim() == "")
        {
            lblMes.Text = "小提示：留言标题不能为空！";
        }
        else
        {
            lblMes.Text = "留言标题为："+txtTitle.Text+"<br>";
            if (txtMessage.Text.Trim() != "")
            {
                lblMes.Text += "内容为："+txtMessage.Text+"<br>";
            }
            lblMes.Text += "留言时间为："+lblTime.Text;
        }
    }
    protected void btnRe_Click(object sender, EventArgs e)
    {
        txtTitle.Text = "";
        txtMessage.Text = "";
        lblMes.Text = "";
        lblTime.Text = DateTime.Now.ToString();
    }
}
