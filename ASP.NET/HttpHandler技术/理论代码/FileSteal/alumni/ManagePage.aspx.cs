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

public partial class ManagePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserInfo userInfo = Session["userInfo"] as UserInfo;


            if ((userInfo == null))
            {
                Response.Redirect("Login.aspx");
            }
            else if ((userInfo.UserName != "administrator") || (userInfo.PassWord != "password"))
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                Response.Write( userInfo.UserName + "欢迎您来到后台管理程序!<br>");
            }


            //查看客户端信息

            Response.Write("<br>客户端信息：<br>");
            Response.Write("<br>浏览器类型：" + Request.Browser.Browser + "<br>");
            Response.Write("浏览器版本：" + Request.Browser.Version + "<br>");
            Response.Write("客户端IP地址：" + Request.UserHostAddress + "<br>");
            Response.Write("客户端主机名：" + Request.UserHostName + "<br>");
            Response.Write("客户端操作系统：" + Request.Browser.Platform + "<br>");

            //服务器端信息

            Response.Write("<br>服务器端信息：<br>");
            Response.Write("<br>服务器机器名称：" + Server.MachineName + "<br>");
            Response.Write("<br>网站根路径：" + Server.MapPath("~/") + "<br>");

        }
    }
}
