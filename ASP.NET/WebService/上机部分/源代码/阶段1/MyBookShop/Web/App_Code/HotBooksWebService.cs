using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using MyBookShop.BLL;
using MyBookShop.Models;

/// <summary>
/// HotBooksWebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class HotBooksWebService : System.Web.Services.WebService
{

    public HotBooksWebService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] GetHotBooks(string title)
    {
        //根据书名的前几个字母,返回查询的结果
        return BookManager.GetHotBooks(title);
    } 

}

