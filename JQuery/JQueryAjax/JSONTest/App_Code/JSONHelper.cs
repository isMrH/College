using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
/// <summary>
///JSONHelper 的摘要说明
/// </summary>
public static  class JSONHelper
{


    /// <summary>
    /// 格式化JSON字符串
    /// </summary>
    /// <param name="obj">被格式化的对象</param>
    /// <returns>JSON字符串</returns>
    public static string ToJson(this object obj)
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        return serializer.Serialize (obj );       

    }

    public static  string ParseJson(string json)
    {
        //Demo.aspx?json={name:'paulleder',id:1}
        string values = "";
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        Dictionary<string,string> jsons = (Dictionary<string,string>)serializer.DeserializeObject(json);
        
        foreach (object value in jsons.Values)
        {
            values += value.ToString();
        }
        return values;

    }

}
