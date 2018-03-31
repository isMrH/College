﻿<%@ WebHandler Language="C#" Class="get1" %>

using System;
using System.Web;

public class get1 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //指定响应类型
        context.Response.ContentType = "text/html";
        //获取客户端传来的名字及内容
        string username=context.Request.QueryString["username"].ToString ();
        string content=context.Request.QueryString["content"].ToString ();
        //输出响应的内容
        context.Response.Write("<div class='comment'><h6> " + username + " :</h6><p class='para'> " 
                                           + content + " </p></div>");
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}