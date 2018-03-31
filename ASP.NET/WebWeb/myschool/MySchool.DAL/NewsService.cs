using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySchool.Model;

namespace MySchool.DAL
{
    public class NewsService
    {
        public static List<News> GetAllNews()
        {
            string strsql = "select * from news";
            return GetNewsBySql(strsql);
        }
        public static List<News> GetAllNews(string sortExpression)
        {
            string strsql = "select * from news";
            if (sortExpression.Length > 0)
            {
                strsql += " order by " + sortExpression;
            }
            return GetNewsBySql(strsql);
        }
        public static List<News> GetNewsByTypeid(int typeid)
        {
            string strsql = "select * from news where typeid="+typeid;
            return GetNewsBySql(strsql);
        }
        public static News GetNewsByNewsId(int newsId)
        {
            string sql = "select * from news where newsid=" + newsId;
            List<News> alltype = GetNewsBySql(sql);
            return alltype[0];
        }
        public static int UpdateInfo(int newsid, string Title,string Contents, int Clicks,int typeid)
        {
            string strsql = string.Format("update news set title='{0}',contents='{1}',clicks={2},typeid={3} where newsid in ({4})",Title,Contents,Clicks,typeid,newsid);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int UpdateTypeID(string newsid, string typeid)
        {
            string strsql = string.Format("update news set typeid={0} where newsid in ({1})",typeid,newsid);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int Update(int newsid,string Title,string Contents,int Clicks ,int State,int IsTop)
        {
            string strsql=string.Format("update news set Title='{0}',Clicks={1},State={2},Contents='{3}',IsTop={4} where newsid={5}",Title,Clicks,State,Contents,IsTop,newsid);
            return DBHelper.ExecuteCommand(strsql);
        }
        private static List<News> GetNewsBySql(string strsql)
        {
            DataTable dt = DBHelper.GetTable(strsql);
            List<News> allnews = new List<News>();
            foreach (DataRow row in dt.Rows)
            {
                News n = new News();
                n.NewsId = Convert.ToInt32(row["newsid"]);
                //n.TypeId = Convert.ToInt32(row["typeid"]);
                n.Type = NewsTypeService.GetNewsTypeByTypeId((int)row["typeid"]);
                n.Title = row["title"].ToString();
                n.PictureUrl = row["pictureurl"].ToString();
                n.PublishDate = Convert.ToDateTime(row["publishdate"]);
                n.PublisherName = row["publishername"].ToString();
                n.Clicks = Convert.ToInt32(row["clicks"]);
                n.State = Convert.ToInt32(row["state"]);
                n.Contents = row["contents"].ToString();
                n.IsTop = Convert.ToInt32(row["istop"]);

                allnews.Add(n);
            }
            return allnews;
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
            catch(Exception e)
            {
                Console.Write(e.Message);
                throw e;
            }
        }
     
    }
}
