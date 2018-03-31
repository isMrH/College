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

public partial class MemberManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //读取Cookie
        string nameCookie = Request.Cookies["userCookie"]["userName"];

        Response.Write("用户名：" + nameCookie);

        string timeCookie = Request.Cookies["userCookie"]["lastVist"];

        Response.Write("<br>上传访问时间：" + timeCookie);


       




    }
}
