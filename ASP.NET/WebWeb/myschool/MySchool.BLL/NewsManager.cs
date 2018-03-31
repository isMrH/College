using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Model;
using MySchool.DAL;

namespace MySchool.BLL
{
    public class NewsManager
    {
        public static List<News> GetAllNews()
        {
            return NewsService.GetAllNews();
        }
        public static List<News> GetAllNews(string sortExpression)
        {
            return NewsService.GetAllNews(sortExpression);
        }
        public static News GetNewsByNewsId(int newsId)
        {
            return NewsService.GetNewsByNewsId(newsId);
        }
        public static int UpdateTypeID(string newsid, string typeid)
        {
            return NewsService.UpdateTypeID(newsid, typeid);
        }
        public static List<News> GetNewsByTypeid(int typeid)
        {
            return NewsService.GetNewsByTypeid(typeid);
        }
        public static void DeleteNewsId(int newsId)
        {
             NewsService.DeleteNewsId(newsId);
        }
        public static int UpdateInfo(int newsid, string Title,string Contents, int Clicks,int typeid)
        {
             return  NewsService.UpdateInfo(newsid, Title,Contents, Clicks,typeid);
        }
        public static int Update(int newsid, string Title, string Contents, int Clicks, int State, int IsTop)
        {
            return NewsService.Update(newsid, Title, Contents, Clicks, State, IsTop);
        }  
    }
}
