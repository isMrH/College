using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
   public static partial class NewsService
	{
        public static News AddNew(News news)
		{
            string sql =
				"INSERT News (TypeId, Title, PictureUrl, PublishDate, PublisherName, Clicks, State, Contents, IsTop)" +
				"VALUES (@TypeId, @Title, @PictureUrl, @PublishDate, @PublisherName, @Clicks, @State, @Contents, @IsTop)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@TypeId", news.Type.TypeId), //FK
					new SqlParameter("@Title", news.Title),
					new SqlParameter("@PictureUrl", news.PictureUrl),
					new SqlParameter("@PublishDate", news.PublishDate),
					new SqlParameter("@PublisherName", news.PublisherName),
					new SqlParameter("@Clicks", news.Clicks),
					new SqlParameter("@State", news.State),
					new SqlParameter("@Contents", news.Contents),
					new SqlParameter("@IsTop", news.IsTop)
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetNewByNewsId(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteNew(News news)
		{
			DeleteNewByNewsId( news.NewsId );
		}

        public static void DeleteNewByNewsId(int newsId)
		{
            string sql = "DELETE News WHERE NewsId = @NewsId";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@NewsId", newsId)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyNew(News news)
        {
            string sql =
                "UPDATE News " +
                "SET " +
	                "TypeId = @TypeId, " + //FK
	                "Title = @Title, " +
	                "PictureUrl = @PictureUrl, " +
	                "PublishDate = @PublishDate, " +
	                "PublisherName = @PublisherName, " +
	                "Clicks = @Clicks, " +
	                "State = @State, " +
	                "Contents = @Contents, " +
	                "IsTop = @IsTop" +	               
                "WHERE NewsId = @NewsId";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@NewsId", news.NewsId),
					new SqlParameter("@TypeId", news.Type.TypeId), //FK
					new SqlParameter("@Title", news.Title),
					new SqlParameter("@PictureUrl", news.PictureUrl),
					new SqlParameter("@PublishDate", news.PublishDate),
					new SqlParameter("@PublisherName", news.PublisherName),
					new SqlParameter("@Clicks", news.Clicks),
					new SqlParameter("@State", news.State),
					new SqlParameter("@Contents", news.Contents),
					new SqlParameter("@IsTop", news.IsTop)
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }

        public static List<News> GetAllNews(string sortExpression)
        {
            string sqlAll = "SELECT * FROM News";
            if (sortExpression.Length > 0)
            {
                sqlAll += " order by " + sortExpression;
            }
            
			return GetNewsBySql( sqlAll );
        }
		
        public static News GetNewByNewsId(int newsId)
        {
            string sql = "SELECT * FROM News WHERE NewsId = @NewsId";

			int typeId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@NewsId", newsId));
                if (reader.Read())
                {
                    News news = new News();

					news.NewsId = (int)reader["NewsId"];
					news.Title = (string)reader["Title"];
					news.PictureUrl = (string)reader["PictureUrl"];
					news.PublishDate = (DateTime)reader["PublishDate"];
					news.PublisherName = (string)reader["PublisherName"];
					news.Clicks = (int)reader["Clicks"];
					news.State = (int)reader["State"];
					news.Contents = (string)reader["Contents"];
					news.IsTop = (int)reader["IsTop"];					
					typeId = (int)reader["TypeId"]; //FK

                    reader.Close();

					news.Type = NewsTypeService.GetNewsTypeByTypeId(typeId);
					
                    return news;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
		
		
		
		
        private static List<News> GetNewsBySql( string safeSql )
        {
            List<News> list = new List<News>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					News news = new News();
					
					news.NewsId = (int)row["NewsId"];
					news.Title = row["Title"]==DBNull .Value ?"":(string)row["Title"];
					news.PictureUrl = row["PictureUrl"]==DBNull .Value ?"":(string)row["PictureUrl"];
					news.PublishDate = (DateTime)row["PublishDate"];
					news.PublisherName = row["PublisherName"]==DBNull .Value ?"":(string)row["PublisherName"];
					news.Clicks = (int)row["Clicks"];
					news.State = (int)row["State"];
					news.Contents =row["Contents"]==DBNull .Value ?"": (string)row["Contents"];
					news.IsTop = (int)row["IsTop"];
					
					news.Type = NewsTypeService.GetNewsTypeByTypeId((int)row["TypeId"]); //FK
	
					list.Add(news);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static List<News> GetNewsBySql( string sql, params SqlParameter[] values )
        {
            List<News> list = new List<News>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					News news = new News();
					
					news.NewsId = (int)row["NewsId"];
					news.Title = (string)row["Title"];
					news.PictureUrl = (string)row["PictureUrl"];
					news.PublishDate = (DateTime)row["PublishDate"];
					news.PublisherName = (string)row["PublisherName"];
					news.Clicks = (int)row["Clicks"];
					news.State = (int)row["State"];
					news.Contents = (string)row["Contents"];
					news.IsTop = (int)row["IsTop"];					
					news.Type = NewsTypeService.GetNewsTypeByTypeId((int)row["TypeId"]); //FK
	
					list.Add(news);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
       /// <summary>
       /// 修改新闻类别
       /// </summary>
       /// <param name="newsId"></param>
       /// <param name="typeId"></param>
        public static void ModifyNewsType(string newsId, int typeId)
        {
            string sql = "update news set typeId="+typeId +" where newsid in ("+newsId +")";           
            DBHelper.ExecuteCommand(sql);
        }
		
	}
}
