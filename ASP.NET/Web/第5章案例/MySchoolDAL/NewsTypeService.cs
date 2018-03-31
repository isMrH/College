using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
    public static partial class NewsTypeService
    {
        public static NewsType AddNewsType(NewsType newsType)
        {
            string sql =
                "INSERT NewsType (Title, Remark)" +
                "VALUES (@Title, @Remark)";

            sql += " ; SELECT @@IDENTITY";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Title", newsType.Title),					
					new SqlParameter("@Remark", newsType.Remark)
				};

                int newId = DBHelper.GetScalar(sql, para);
                return GetNewsTypeByTypeId(newId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static void DeleteNewsType(NewsType newsType)
        {
            DeleteNewsTypeByTypeId(newsType.TypeId);
        }

        public static void DeleteNewsTypeByTypeId(int typeId)
        {
            string sql = "DELETE NewsType WHERE TypeId = @TypeId";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@TypeId", typeId)
				};

                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static void ModifyNewsType(NewsType newsType)
        {
            string sql =
                "UPDATE NewsType " +
                "SET " +
                    "Title = @Title, " +                   
                    "Remark = @Remark " +
                "WHERE TypeId = @TypeId";


            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@TypeId", newsType.TypeId),
					new SqlParameter("@Title", newsType.Title),					
					new SqlParameter("@Remark", newsType.Remark)
				};

                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        public static List<NewsType> GetAllNewsTypes()
        {
            string sqlAll = "SELECT * FROM NewsType";
            return GetNewsTypesBySql(sqlAll);
        }

        public static NewsType GetNewsTypeByTypeId(int typeId)
        {
            string sql = "SELECT * FROM NewsType WHERE TypeId = @TypeId";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@TypeId", typeId));
                if (reader.Read())
                {
                    NewsType newsType = new NewsType();

                    newsType.TypeId = (int)reader["TypeId"];
                    newsType.Title = (string)reader["Title"];                 
                    newsType.Remark = (string)reader["Remark"];

                    reader.Close();

                    return newsType;
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




        private static List<NewsType> GetNewsTypesBySql(string safeSql)
        {
            List<NewsType> list = new List<NewsType>();

            try
            {
                DataTable table = DBHelper.GetDataTable (safeSql);

                foreach (DataRow row in table.Rows)
                {
                    NewsType newsType = new NewsType();

                    newsType.TypeId = (int)row["TypeId"];
                    newsType.Title = (string)row["Title"];                   
                    newsType.Remark = (string)row["Remark"];

                    list.Add(newsType);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        private static List<NewsType> GetNewsTypesBySql(string sql, params SqlParameter[] values)
        {
            List<NewsType> list = new List<NewsType>();

            try
            {
                DataTable table = DBHelper.GetDataTable (sql, values);

                foreach (DataRow row in table.Rows)
                {
                    NewsType newsType = new NewsType();

                    newsType.TypeId = (int)row["TypeId"];
                    newsType.Title = (string)row["Title"];                   
                    newsType.Remark = (string)row["Remark"];

                    list.Add(newsType);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

    }
}
