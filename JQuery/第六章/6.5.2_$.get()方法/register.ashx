<%@ WebHandler Language="C#" Class="register" %>

using System;
using System.Web;

public class register : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //设置服务器输出流的HTTP MIME类型
        context.Response.ContentType = "text/plain";
        string result = "1";
        foreach (User u in Users.UserList)
        {
            if (u.Name == context.Request["txtName"])
            {
                result = "0";
                break;
            }
        }
        context.Response.Write(result);
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}