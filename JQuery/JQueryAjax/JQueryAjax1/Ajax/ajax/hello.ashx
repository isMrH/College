<%@ WebHandler Language="C#" Class="hello" %>

using System;
using System.Web;

public class hello : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //设置服务器输出流的HTTP MIME类型
        context.Response.ContentType = "text/plain";
        //清除浏览器缓存
        context.Response.AddHeader("Cache-Control", "no-cache");
        string str = "Hello ";
        str += context.Request["name"];
        context.Response.Write(str);
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}