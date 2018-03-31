<%@ WebHandler Language="C#" Class="Register" %>

using System;
using System.Web;
using MyBlogBLL;
using MyBlogModels;

public class Register : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        if (context.Request["UserName"] != null)
        {
            if (UserManager.IsUserNameRegister(context.Request["UserName"].ToString()))
            {
                context.Response.Write("<font color='red' >该用户名已经被占用</font>");
            }
            else
            {
                context.Response.Write("<font color='green' >恭喜您，用户名可以使用</font>");
            }
        }

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}