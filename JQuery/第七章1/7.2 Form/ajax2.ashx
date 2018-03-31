<%@ WebHandler Language="C#" Class="ajax2" %>

using System;
using System.Web;

public class ajax2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";        
        string name=context .Request ["name"].ToString ();
        string address=context .Request ["address"].ToString ();
        string comment=context .Request ["comment"].ToString ();

        context.Response.Write(" <h1>"+name+","+address+","+comment+"</h1>");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}