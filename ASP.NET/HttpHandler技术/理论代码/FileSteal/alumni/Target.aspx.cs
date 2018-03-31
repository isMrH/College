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

public partial class Target : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            TextBox SourceTextBox =
                (TextBox)Page.PreviousPage.FindControl("txtMessage");
            if (SourceTextBox != null)
            {
               

                lblContent.Text = "跨页传递的内容为：" + SourceTextBox.Text;
            }
        }




    }
}
