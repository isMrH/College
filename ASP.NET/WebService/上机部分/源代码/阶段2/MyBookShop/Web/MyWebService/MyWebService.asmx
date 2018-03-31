<%@ WebService Language="C#" Class="MyWebService" %>
using System;
using System.Web;

using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using MyBookShop.BLL;
using MyBookShop.Models;


/// <summary>
/// MyWebService ��ժҪ˵��
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService()]

public class MyWebService : System.Web.Services.WebService
{

    public MyWebService()
    {

        //���ʹ����Ƶ��������ȡ��ע�������� 
        //InitializeComponent(); 
    }

    [WebMethod]

    public string[] GetHotSearchByKeywords(string keyword)
    {
        //���ݹؼ��ֺ���ʾ����,���ز�ѯ�Ľ��
        return SearchKeywordManager.GetHotSearchKeywords(keyword);
    } 

}

