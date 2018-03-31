using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class BookService
    {
        //查询所有图书信息
        public static List<Book> GetAllBooks()
        {
            string strsql = "select * from Books";
            return GetBooksBySql(strsql);
        }
        //根据条形码查询图书信息
        public static Book Getbookisbn(string isbn)
        {
            string sql = "select * from Books where ISBN='" + isbn + "'";
            List<Book> allBooks = GetBooksBySql(sql);
            return allBooks[0];
        }
        //根据id查询图书信息
        public static Book GetbookisByid(int id)
        {
            string sql = "select * from Books where id=" + id;
            List<Book> allBooks = GetBooksBySql(sql);
            return allBooks[0];
        }
        //根据数量查询图书信息
        public static List<Book> Getbooknumber(int number)
        {
            string sql = "select top " + number + " * from Books ";
            return GetBooksBySql(sql);
        }
        //私有方法查询
        private static List<Book> GetBooksBySql(string strsql)
        {
            DataTable dt = DBHelper.GetTable(strsql);
            List<Book> allBooks = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                Book bs = new Book();
                bs.Id = Convert.ToInt32(row["id"]);
                bs.Title = row["title"].ToString();
                bs.Author = row["author"].ToString();
                bs.CategoryId = Convert.ToInt32(row["CategoryId"]);
                bs.UnitPrice = Convert.ToDouble(row["UnitPrice"]);
                bs.Clicks = Convert.ToInt32(row["Clicks"]);
                bs.PublisherId = Convert.ToInt32(row["PublisherId"]);
                bs.PublishDate = Convert.ToDateTime(row["PublishDate"]);
                bs.ISBN = row["ISBN"].ToString();
                bs.WordsCount = Convert.ToInt32(row["WordsCount"]);
                bs.ContentDescription = row["ContentDescription"].ToString();
                bs.AurhorDescription = row["AurhorDescription"].ToString();
                bs.EditorComment = row["EditorComment"].ToString();
                bs.TOC = row["TOC"].ToString();
                bs.Category = CategoryService.GetCategoriesByID(Convert.ToInt32(row["CategoryId"]));
                bs.Publisher = PublisherService.GetPublishersByID(Convert.ToInt32(row["PublisherId"]));

                allBooks.Add(bs);
            }
            return allBooks;
        }
    }
}
