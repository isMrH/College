<%@ WebHandler Language="C#" Class="Login" %>

using System;
using System.Web;
using MyBlogBLL;
using MyBlogModels;

public class Login : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        
        string name = context.Request["txtLoginId"];//获取文本框的值
        string result=UserManager.IsUserNameRegister(name).ToString();//调用验重方法  获得返回值
        context.Response.Write(result);//输出返回值
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}