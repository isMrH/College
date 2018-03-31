using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.DAL;
using MySchool.Model;

namespace MySchool.BLL
{
    public class NewsManager
    {
        public static List<News> GetAllNews()
        {
            return NewsService.GetAllNews();
        }
        public static void DeleteNewsId(int newsId)
        {
            NewsService.DeleteNewsId(newsId);
        }
    }
}
