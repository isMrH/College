using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// FileHandler 的摘要说明
/// </summary>
public class FileHandler:IHttpHandler
{
	public FileHandler()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public void ProcessRequest(HttpContext context)
    {
        if ((context.Request.UrlReferrer != null) && (context.Request.UrlReferrer.Host == "localhost" && context.Request.UrlReferrer.Port == 16490))
        {
            context.Response.Expires = 0;
            context.Response.Clear();
            context.Response.ContentType = "rar";
            context.Response.WriteFile(context.Request.PhysicalPath);
            context.Response.End();
        }
        else     //如果不是本地引用，则属于盗链引用，
        {

            HttpResponse response = context.Response;
            response.Redirect(context.Request.ApplicationPath + "/ErrorPage.htm");
            //context.Response.Write("请不要盗链本站资源");
        }

    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}
