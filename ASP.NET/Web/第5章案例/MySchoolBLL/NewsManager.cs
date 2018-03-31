using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
   public static partial class NewsManager
    {
        public static News AddNew(News news)
        {
            return NewsService.AddNew(news);
        }

        public static void DeleteNew(News news)
        {
            NewsService.DeleteNew(news);
        }

        public static void DeleteNewById(int newsId)
        {
            NewsService.DeleteNewByNewsId (newsId);
        }

		public static void ModifyNew(News news)
        {
            NewsService.ModifyNew(news);
        }

        public static List<News> GetAllNews(string sortExpression)
        {
            return NewsService.GetAllNews(sortExpression);
        }

        public static News GetNewByNewsId(int newsId)
        {
            return NewsService.GetNewByNewsId(newsId);
        }
        /// <summary>
       /// 修改新闻类别
       /// </summary>
       /// <param name="newsId"></param>
       /// <param name="typeId"></param>
        public static void ModifyNewsType(string newsId, int typeId)
        {
            NewsService.ModifyNewsType(newsId, typeId);
        }

    }
}
