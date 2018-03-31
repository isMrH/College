<%@ WebService Language="C#" Class="MyWebService" %>
using System;
using System.Web;

using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using MyBookShop.BLL;
using MyBookShop.Models;


/// <summary>
/// MyWebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService()]

public class MyWebService : System.Web.Services.WebService
{

    public MyWebService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]

    public string[] GetHotSearchByKeywords(string keyword)
    {
        //根据关键字和显示行数,返回查询的结果
        return SearchKeywordManager.GetHotSearchKeywords(keyword);
    } 

}

