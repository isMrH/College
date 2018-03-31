using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySchool.Model;

namespace MySchool.DAL
{
   public class NewsService
    {
        public static List<News> GetAllNews()
        {
            string sql = "select * from News";
            return GetNewsBySql(sql);
        }
        private static List<News> GetNewsBySql(string sql)
        {
            List<News> lists = new List<News>();

            DataTable dt = DBHelper.GetTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                News news = new News();

                news.NewsId = (int)row["NewsId"];
                news.Title = row["Title"].ToString();
                news.PictureUrl = row["PictureUrl"].ToString();
                news.PublishDate = (DateTime)row["PublishDate"];
                news.PublisherName = row["PublisherName"].ToString();
                news.Clicks = (int)row["Clicks"];
                news.State = (int)row["State"];
                news.Contents = row["Contents"].ToString();
                news.IsTop = (int)row["IsTop"];
                //news.TypeId = (int)row["TypeId"];
                news.Type = NewsTypeService.GetNewsTypeByTypeId((int)row["typeId"]);
                lists.Add(news);
            }
            return lists;
        }
        public static News GetNewByNewsId(int newsId)
        {
            string sql = "select * from news where newsid=" + newsId;
            List<News> lists = GetNewsBySql(sql);
            return lists[0];
        }
        public static void DeleteNewsId(int newsId)
        {
            string sql = "delete news where newsid=@newsid";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@newsid",newsId)
                };
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                throw e;
            }
        }
      
    }
}
