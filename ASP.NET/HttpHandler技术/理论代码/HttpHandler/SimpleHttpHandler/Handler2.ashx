<%@ WebHandler Language="C#" Class="Handler2" %>

using System;
using System.Web;

public class Handler2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.Write("<H1>This is an HttpHandler Test.</H1>");
        context.Response.Write("<p>Your Browser:</p>");
        context.Response.Write("Type: " + context.Request.Browser.Type + "<br>");
        context.Response.Write("Version: " + context.Request.Browser.Version);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}