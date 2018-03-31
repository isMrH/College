<%@ WebHandler Language="C#" Class="html" %>

using System;
using System.Web;

public class html : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //设置服务器输出流的HTTP MIME类型
        context.Response.ContentType = "text/html";
        //清缓存
        context.Response.AddHeader("Cache-Control", "no-cache");
        string strHtml = "<font color='red' size='7'><b>" + context.Request["area"] + "时间  " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "</b></font>";
        context.Response.Write(strHtml);
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}