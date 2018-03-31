using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MyBookShop.BLL;

public partial class Rss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rptRss.DataSource = BookManager.GetBooks(" Top 20 Id, Title,PublisherId, Author,SubString(ContentDescription,0,200) as ShortContent, PublishDate ", 0, " PublishDate desc");
        rptRss.DataBind();
    }
    /// <summary>
    /// 执行html编码
    /// </summary>
    /// <param name="obj">绑定的数据</param>
    /// <returns></returns>
    public string EnCode(object obj)
    {
        return Server.HtmlEncode(obj as string);
    }
    /// <summary>
    /// 由于是开发服务器，需生成路径
    /// </summary>
    /// <param name="obj">路径id</param>
    /// <returns></returns>
    public string GetUrl(object obj)
    {
        return "http://"+Request.ServerVariables["HTTP_HOST"].ToString()
            + "/web/BookDetail.aspx?bid=" + obj as string;
    }
}
