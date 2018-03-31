<%@ WebHandler Language="C#" Class="post3" %>

using System;
using System.Web;

public class post3 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //获取客户端传来的名字及内容
        string username = context.Request["username"].ToString();
        string content = context.Request["content"].ToString();
        //拼写JSON串
        string responseText = "{ \"username\" :\"" + username + "\" , \"content\" :\"" + content + "\"}";
        context.Response.Write(responseText);
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}