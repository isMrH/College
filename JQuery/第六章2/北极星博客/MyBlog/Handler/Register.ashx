<%@ WebHandler Language="C#" Class="Register" %>

using System;
using System.Web;
using MyBlogBLL;
using Myblog.Model;

public class Register : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        //文本编码
        context.Response.ContentType = "text/plain";
        //验证传值是否为空
        if (context.Request["UserName"] != null)
        {
            //验证用户名是否存在
            if (UserManager.IsUserNameRegister(context.Request["UserName"].ToString()))
            {
                //返回结果
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