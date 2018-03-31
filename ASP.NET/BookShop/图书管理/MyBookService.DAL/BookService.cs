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
        public List<Book> GetAllBooks()
        {
            string strsql = "select * from Books";
            return GetBooksBySql(strsql);
        }
        //根据类别查询图书信息
        public IList<Book> GetBooksByTypeid(int categoryId, string order)
        {
            string strsql = "select Id,ISBN, Title, Author,CategoryId, PublisherId, PublishDate,Clicks,WordsCount,AurhorDescription,EditorComment, TOC,UnitPrice,SubString(ContentDescription,0,200) as ContentDescription from Books";
            if (categoryId > 0)
            {
                strsql += " where CategoryId = " + categoryId;
            }
            if (order.Trim().Length > 0)
            {
                strsql += " order by " + order;
            }
            return GetBooksBySql(strsql);
        }
        //查询是否有符合该isbn号的记录
        public int IsHasInfo(string isbn)
        {
            string strsql = "select count(*) from Books where ISBN='"+isbn+"'";
            return Convert.ToInt32( DBHelper.GetScalar(strsql));
        }
        //根据条形码查询图书信息
        public Book Getbookisbn(string isbn)
        {
            string sql = "select * from Books where ISBN='" + isbn + "'";
            List<Book> allBooks = GetBooksBySql(sql);
            return allBooks[0];
        }
        //根据id查询图书信息
        public Book GetbookisByid(int id)
        {
            string sql = "select * from Books where id=" + id;
            List<Book> allBooks = GetBooksBySql(sql);
            return allBooks[0];
        }
        //根据类型id获得
        public List<Book> GetBooksByCategoryId(int id)
        { 
           string strsql ="select top 5 * from Books where CategoryId="+id+" order by Clicks desc";
           return GetBooksBySql(strsql);
        }
        //根据数量查询图书信息
        public List<Book> Getbooknumber(int number)
        {
            string sql = "select top " + number + " * from Books ";
            return GetBooksBySql(sql);
        }
        //自动补全
        public string[] GetHotSearchKeyWords(string prefixText, int count)
        {
            try
            {
                string strsql = "select top " + count + " * from Books  where  Title like '" + prefixText + "%' order by Clicks desc";
                string[] dispalycount = new string[count];
                List<string> list = new List<string>();
                DataTable dr = DBHelper.GetTable(strsql);
                foreach (DataRow row in dr.Rows)
                {
                    list.Add(row["Title"].ToString());
                }
                dispalycount = list.ToArray();
                return dispalycount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //私有方法查询
        private static List<Book> GetBooksBySql(string strsql)
        {
            CategoryService cs = new CategoryService();
            PublisherService ps = new PublisherService();
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
                bs.Category = cs.GetCategoriesByID(Convert.ToInt32(row["CategoryId"]));
                bs.Publisher = ps.GetPublishersByID(Convert.ToInt32(row["PublisherId"]));

                allBooks.Add(bs);
            }
            return allBooks;
        }
    }
}
