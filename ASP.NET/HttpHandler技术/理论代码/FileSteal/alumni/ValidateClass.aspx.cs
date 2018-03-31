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

public partial class ValidateClass : System.Web.UI.Page
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


                    lblName.Text = "<br>班级名称：" + SourceName.Text;
                }

                TextBox SourceEnter =
                   (TextBox)Page.PreviousPage.FindControl("txtEnter");
                if (SourceEnter != null)
                {


                    lblEnter.Text = "<br>入学年月：" + SourceEnter.Text;
                }

                TextBox SourceLeave =
                (TextBox)Page.PreviousPage.FindControl("txtLeave");
                if (SourceLeave != null)
                {


                    lblLeave.Text = "<br>毕业年月：" + SourceLeave.Text;
                }

                TextBox SourceSchool =
                           (TextBox)Page.PreviousPage.FindControl("txtSchool");
                if (SourceSchool != null)
                {


                    lblSchool.Text = "<br>所在学校：" + SourceSchool.Text;
                }

                TextBox SourceCreateTime =
                                      (TextBox)Page.PreviousPage.FindControl("txtCreateTime");
                if (SourceCreateTime != null)
                {


                    lblCreateTime.Text = "<br>注册时间：" + SourceCreateTime.Text;
                }


            }

        }

    }
}
