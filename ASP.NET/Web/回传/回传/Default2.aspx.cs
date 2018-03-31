using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 回传
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.PreviousPage != null)
            {
                if (this.PreviousPage.IsCrossPagePostBack)
                {
                    TextBox txtName = this.PreviousPage.FindControl("txtName") as TextBox;
                    RadioButtonList rdoSex = this.PreviousPage.FindControl("rdoSex") as RadioButtonList;
                    if (txtName != null)
                    {
                        Response.Write("姓名：" + txtName.Text);

                        Response.Write("性别：" + rdoSex.Items);
                    }
                }
            }
        }
    }
}
