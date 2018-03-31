using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySchool.BLL;
using MySchool.Model;

public partial class AdminNews_NewsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["newsid"] != null)
        {
            int newsid = Convert.ToInt32(Request.QueryString["newsid"]);
            //根据新闻ID获取新闻信息
            //News news = NewsManager.GetNewByNewsId(newsid);
            //将获取的新闻信息在页面显示
            //if (news != null)
            //{
            //    lblTitle.Text = news.Title;
            //    lblContents.Text = news.Contents;
            //    lblClicks.Text =news.Clicks.ToString ();
            //    lblPubliserName.Text = news.PublisherName;
            //    lblPublisherDate.Text = news.PublishDate.ToString ();
            //    lblState.Text = news.State == 1? "启用" : "禁用";
            //    lblType.Text = news.Type.Title;
            //    lblTop.Text = news.IsTop==1?"置顶":"非置顶";
            //    imgNews.ImageUrl ="~/userFiles/"+ news.PictureUrl;               
               
            //}


        }
    }
}