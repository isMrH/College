using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///StringHandler 的摘要说明
/// </summary>
public static class StringHandler
{
	
    /// <summary>
    /// 截断字符串
    /// </summary>
    /// <param name="content"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public static string CutString(object content, int num)
    {
        if (content.ToString().Length > num )
            return content.ToString().Substring(0, num ) + "...";
        else
            return content.ToString();
    }
    /// <summary>
    /// 货币
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToMoney(object obj)
    {
        return String.Format("{0:C}", obj);
    }
    /// <summary>
    /// 短日期
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static String ToShortDate(object obj)
    {
        return Convert.ToDateTime(obj).ToShortDateString();
    }
}