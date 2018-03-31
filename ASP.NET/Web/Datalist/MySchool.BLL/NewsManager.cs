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
        //查找所有的新闻
        public static List<News> GetAllNews()
        {
            return NewsService.GetAllNews();
        }

        public static News GetNewsByNewsId(int newsid)
        {
            return NewsService.GetNewsByNewsId(newsid);
        }
        public static List<News> GetAllNewsByTypeId(int typeid)
        {
            return NewsService.GetAllNewsByTypeId(typeid);
        }
    }
}