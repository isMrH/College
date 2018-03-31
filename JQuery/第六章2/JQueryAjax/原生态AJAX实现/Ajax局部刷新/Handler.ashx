<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //获取传递过来的参数
        string city = context.Request .QueryString["city"];
        context.Response .Clear();
        //判断城市名
        switch (city)
        {
            case "beijing":
                context.Response.Write("朝阳,海淀,东城,西城");
                break;
            case "shanghai":
                context.Response.Write("浦东,静安,虹口,徐汇");
                break;
            case "jinan":
                context.Response.Write("历下,历城,市中,天桥");
                break;
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}