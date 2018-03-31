//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:18
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{
	public static partial class ReaderCommentService
	{
        public static ReaderComment AddReaderComment(ReaderComment readerComment)
		{
            string sql =
				"INSERT ReaderComments (Id, BookId, Title, Comment, Date)" +
				"VALUES (@Id, @BookId, @Title, @Comment, @Date)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@BookId", readerComment.Book.Id), //FK
					new SqlParameter("@Id", readerComment.Id),
					new SqlParameter("@Title", readerComment.Title),
					new SqlParameter("@Comment", readerComment.Comment),
					new SqlParameter("@Date", readerComment.Date)
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetReaderCommentByReaderName(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                return null;
            }
		}
		
        public static void DeleteReaderComment(ReaderComment readerComment)
		{
			DeleteReaderCommentByReaderName( readerComment.ReaderName );
		}

        public static void DeleteReaderCommentByReaderName(string readerName)
		{
            string sql = "DELETE ReaderComments WHERE ReaderName = @ReaderName";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@ReaderName", readerName)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyReaderComment(ReaderComment readerComment)
        {
            string sql =
                "UPDATE ReaderComments " +
                "SET " +
	                "BookId = @BookId, " + //FK
	                "Id = @Id, " +
	                "Title = @Title, " +
	                "Comment = @Comment, " +
	                "Date = @Date " +
                "WHERE ReaderName = @ReaderName";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@ReaderName", readerComment.ReaderName),
					new SqlParameter("@BookId", readerComment.Book.Id), //FK
					new SqlParameter("@Id", readerComment.Id),
					new SqlParameter("@Title", readerComment.Title),
					new SqlParameter("@Comment", readerComment.Comment),
					new SqlParameter("@Date", readerComment.Date)
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<ReaderComment> GetAllReaderComments()
        {
            string sqlAll = "SELECT * FROM ReaderComments";
			return GetReaderCommentsBySql( sqlAll );
        }
		
        public static ReaderComment GetReaderCommentByReaderName(string readerName)
        {
            string sql = "SELECT * FROM ReaderComments WHERE ReaderName = @ReaderName";

			int bookId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@ReaderName", readerName));
                if (reader.Read())
                {
                    ReaderComment readerComment = new ReaderComment();

					readerComment.Id = (int)reader["Id"];
					readerComment.ReaderName = (string)reader["ReaderName"];
					readerComment.Title = (string)reader["Title"];
					readerComment.Comment = (string)reader["Comment"];
					readerComment.Date = (DateTime)reader["Date"];
					bookId = (int)reader["BookId"]; //FK

                    reader.Close();

					readerComment.Book = BookService.GetBookById(bookId);
					
                    return readerComment;
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
                return null;
            }
        }
		
		
		
		
        private static IList<ReaderComment> GetReaderCommentsBySql( string safeSql )
        {
            List<ReaderComment> list = new List<ReaderComment>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					ReaderComment readerComment = new ReaderComment();
					
					readerComment.Id = (int)row["Id"];
					readerComment.ReaderName = (string)row["ReaderName"];
					readerComment.Title = (string)row["Title"];
					readerComment.Comment = (string)row["Comment"];
					readerComment.Date = (DateTime)row["Date"];
					readerComment.Book = BookService.GetBookById((int)row["BookId"]); //FK
	
					list.Add(readerComment);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
		
        private static IList<ReaderComment> GetReaderCommentsBySql( string sql, params SqlParameter[] values )
        {
            List<ReaderComment> list = new List<ReaderComment>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					ReaderComment readerComment = new ReaderComment();
					
					readerComment.Id = (int)row["Id"];
					readerComment.ReaderName = (string)row["ReaderName"];
					readerComment.Title = (string)row["Title"];
					readerComment.Comment = (string)row["Comment"];
					readerComment.Date = (DateTime)row["Date"];
					readerComment.Book = BookService.GetBookById((int)row["BookId"]); //FK
	
					list.Add(readerComment);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
			
        }
		
	}
}
