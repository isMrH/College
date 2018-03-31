using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySchool.Model;

namespace MySchool.DAL
{
    public class NewsService
    {
        //查找所有的新闻
        public static List<News> GetAllNews()
        {
            string strsql = "select * from News";
            //调用根据SQL语句查找所有的新闻方法
            return GetAllNewsBySql(strsql);
        }

        //根据SQL语句查找所有的新闻
        public static List<News> GetAllNewsBySql(string strsql)
        {
            List<News> allnew = new List<News>();

            DataTable dt = DBHelper.GetTable(strsql);

            foreach (DataRow row in dt.Rows)
            {
                News news = new News();
                news.Newsid = int.Parse(row["NewsId"].ToString());
                //news.TypeId = int.Parse(row["TypeId"].ToString());
                news.Type = NewsTypeService.GetAllTypeByTypeId((int)row["typeid"]);
                news.Pictureurl = row["PictureUrl"].ToString();
                news.Publishdate = Convert.ToDateTime(row["PublishDate"].ToString());
                news.Istop = int.Parse(row["IsTop"].ToString());
                news.Publishername = row["PublisherName"].ToString();
                news.State = int.Parse(row["State"].ToString());
                news.Titel = row["Title"].ToString();
                news.Contents = row["Contents"].ToString();

                allnew.Add(news);
            }
            return allnew;
        }

        public static News GetNewsByNewsId(int newsid)
        {
            string strsql = "select * from news where newsid=" + newsid;

            List<News> news = GetAllNewsBySql(strsql);

            return news[0];
        }

        public static List<News> GetAllNewsByTypeId(int typeid)
        {
            string strsql = "select * from news where typeid=" + typeid;

            return GetAllNewsBySql(strsql);
        }
    }
}
