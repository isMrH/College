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
        public static string[] GetHotBooks(string title)
        {
            IList<Book> books = new List<Book>();
            List<string> results = new List<string>();

            string sqlHot = "select top 3 * from books where title like '"+title+"%' order by clicks desc";
            books = GetBooksBySql(sqlHot);

            foreach (Book item in books)
            {
                results.Add(item.Title);
            }

            return results.ToArray();
        }       
    }
}
