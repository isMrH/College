<%@ WebHandler Language="C#" Class="register" %>

using System;
using System.Web;

public class register : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string result = "1";
        foreach (User user in Users.UserList)
        {
            if (user.Name == context.Request["txtname"])
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