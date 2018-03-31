using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Model;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
    public class NewsService
    {
        public static List<News> GetAllNews()
        {
            string strsql = "select * from News";
            DataTable dt = DBHelper.GetTable(strsql);
            List<News> news = new List<News>();
                     
           
            foreach (DataRow row in dt.Rows)
            {
                News newss = new News();
                newss.NewsId = Convert.ToInt32(row["NewsId"].ToString());
                newss.TypeId = Convert.ToInt32(row["TypeId"].ToString());
                newss.Title = row["Title"].ToString();
                newss.PictureUrl = row["PictureUrl"].ToString();
                newss.PublishDate = Convert.ToDateTime(row["PublishDate"].ToString());
                newss.PublisherName = row["PublisherName"].ToString();
                newss.Clicks = Convert.ToInt32(row["Clicks"].ToString());
                newss.State = Convert.ToInt32(row["State"].ToString());
                newss.Contents = row["Contents"].ToString();
                newss.IsTop =Convert.ToInt32( row["IsTop"].ToString());
                news.Add(newss);
 
            }
            return news;
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
