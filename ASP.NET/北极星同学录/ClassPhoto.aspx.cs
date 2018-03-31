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

public partial class ClassPhoto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string AddWaterMark(string path)
    {
        string imgurl;
        if (path != null)
        {
            imgurl = "PictureHandler.ashx?pictureName=" + path;

        }
        else
        {
            imgurl = "PictureHandler.ashx?pictureName=" + null;
        }
        return imgurl;
    }
}
