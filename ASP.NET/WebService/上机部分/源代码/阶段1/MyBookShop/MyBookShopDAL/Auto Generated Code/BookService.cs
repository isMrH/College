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
	public static partial class BookService
	{       		
        private static IList<Book> GetBooksBySql( string safeSql )
        {
            List<Book> list = new List<Book>();
			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );				
				foreach (DataRow row in table.Rows)
				{
					Book book = new Book();					
					book.Id = (int)row["Id"];
					book.Title = (string)row["Title"];
					book.Author = (string)row["Author"];
					book.PublishDate = (DateTime)row["PublishDate"];
					book.ISBN = (string)row["ISBN"];
					book.WordsCount = (int)row["WordsCount"];
					book.UnitPrice = (decimal)row["UnitPrice"];
					book.ContentDescription = (string)row["ContentDescription"];
					book.AurhorDescription = (string)row["AurhorDescription"];
					book.EditorComment = (string)row["EditorComment"];
					book.TOC = (string)row["TOC"];
					book.Clicks = (int)row["Clicks"];         

					list.Add(book);
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
