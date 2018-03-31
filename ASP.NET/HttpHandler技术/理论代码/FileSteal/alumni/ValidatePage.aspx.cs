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

public partial class ValidatePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            if (PreviousPage.IsCrossPagePostBack == true)
            {

                TextBox SourceName =
                    (TextBox)Page.PreviousPage.FindControl("txtName");
                if (SourceName != null)
                {


                    lblName.Text = "<br>姓  名：" + SourceName.Text;
                }

                TextBox SourcePsd =
                   (TextBox)Page.PreviousPage.FindControl("txtPsd");
                if (SourcePsd != null)
                {


                    lblPsd.Text = "<br>密  码：" + SourcePsd.Text;
                }

                TextBox SourceEmail =
                (TextBox)Page.PreviousPage.FindControl("txtEmail");
                if (SourceEmail != null)
                {


                    lblEmail.Text = "<br>电子邮件：" + SourceEmail.Text;
                }

                TextBox SourceQuestion =
                           (TextBox)Page.PreviousPage.FindControl("txtQuestion");
                if (SourceQuestion != null)
                {


                    lblQuestion.Text = "<br>密码问题：" + SourceQuestion.Text;
                }

                TextBox SourceAnswer =
                                      (TextBox)Page.PreviousPage.FindControl("txtAnswer");
                if (SourceAnswer != null)
                {


                    lblAnswer.Text = "<br>密码答案：" + SourceAnswer.Text + "<br>";
                }

                imgPerson.ImageUrl = "PictureHandler.ashx?pictureName="+Session["fileName"].ToString();
            }

        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert(\"用户注册成功！\")</script>");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegisterPage.aspx");
    }
}
