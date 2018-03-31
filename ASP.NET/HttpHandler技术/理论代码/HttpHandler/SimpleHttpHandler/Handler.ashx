<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler {

    /// <summary>
    /// 通过实现 IHttpHandler 接口的自定义 HttpHandler 启用 HTTP Web 请求的处理。
    /// </summary>
    /// <param name="context">HttpContext 对象，
    /// 它提供对用于为 HTTP 请求提供服务的内部服务器对象
    /// （如 Request、Response、Session 和 Server）的引用。 </param>

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        context.Response.Write("Hello World");
    }

    /// <summary>
    /// 获取一个值，该值指示其他请求是否可以使用 IHttpHandler 实例。
    /// Page类上的IsReusable属性返回false，表示需要该HTTP请求的新实例
    /// 来服务一个页面请求。通常我们使它在所有情况下都返回false，
    /// 并根据请求负荷的不同而要求它做一些有意义的处理。那些被用作筛选特殊
    /// 请求的简单屏障的处理程序可以将IsReusable设置为true，以节省一些CPU周期。
    /// </summary>

    public bool IsReusable {
        get {
            return false;
        }
    }

}