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
        public static News GetNewByNewsId(int newsId)
        {
            return NewsService.GetNewByNewsId(newsId);
        }
        public static void DeleteNewsId(int newsId)
        {
            NewsService.DeleteNewsId(newsId);
        }
    }
}
