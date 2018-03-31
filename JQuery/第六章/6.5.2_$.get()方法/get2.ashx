<%@ WebHandler Language="C#" Class="get2" %>

using System;
using System.Web;

public class get2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        
        //指定响应类型
         context.Response.ContentType = "text/xml"; 
        //获取客户端传来的名字及内容
        string username=context.Request.QueryString["username"].ToString ();
        string content=context.Request.QueryString["content"].ToString ();

        //输出响应的XML文档
        context.Response.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
        context.Response.Write ("<comments>");
        context.Response.Write ("<comment username='"+username +"'>");
        context.Response.Write ("<content>"+content+"</content>");
        context.Response.Write ("</comment>");
        context.Response.Write  ("</comments>");
        context.Response.End();

    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}