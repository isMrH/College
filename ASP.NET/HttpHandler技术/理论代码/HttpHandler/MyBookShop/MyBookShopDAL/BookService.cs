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
        #region ��
        /// <summary>
        /// �̶��ķ��������ֶε�ͼ���б�
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static IList<Book> GetSmallBooks(int categoryId, string order)
        {
            return GetBooks("Id,ISBN, Title, Author, PublisherId, PublishDate, UnitPrice,SubString(ContentDescription,0,200) as ShortContent", categoryId, order);
        }
        /// <summary>
        /// Ϊ���ӷ�����������ӵķ���
        /// </summary>
        /// <param name="field"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static IList<Book> GetBooks(string field, int categoryId, string order)
        {           
            //��ϵ��������
            string condition = "";
            if (categoryId > 0)
                condition = " WHERE CategoryId = " + categoryId;
            if (order.Trim().Length > 0)
                condition = " order by " + order;
            return GetSmallBooksBySql("SELECT " + field + " FROM books " + condition);
        }
        /// <summary>
        /// ���ز������ֶε�ͼ��
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        private static IList<Book> GetSmallBooksBySql(string safeSql)
        {
            List<Book> list = new List<Book>();
            DataTable table = DBHelper.GetDataSet(safeSql);
            foreach (DataRow row in table.Rows)
            {
                Book book = new Book();
                book.Id = (int)row["Id"];
                book.Title = (string)row["Title"];
                book.Author = (string)row["Author"];

                if (table.Columns.Contains("UnitPrice"))
                    book.UnitPrice = (decimal)row["UnitPrice"];
                if (table.Columns.Contains("ShortContent"))
                    book.ContentDescription = (string)row["ShortContent"];
                if (table.Columns.Contains("ISBN"))
                    book.ISBN = (string)row["ISBN"];
                if (table.Columns.Contains("PublishDate"))
                    book.PublishDate = (DateTime)row["PublishDate"];
                if (table.Columns.Contains("CategoryId"))
                    book.Category = CategoryService.GetCategoryById((int)row["CategoryId"]);
                book.Publisher = PublisherService.GetPublisherById((int)row["PublisherId"]); //FK
                list.Add(book);
            }
            return list;
        }
        #endregion
        #region ��
        /// <summary>
        /// ����ͼ�����ķ���
        /// </summary>
        /// <param name="sbs"></param>
        /// <param name="catagory"></param>
        public static void ModifyBook(string[] sbs, string catagory)
        {
            SqlParameter[] para = null;
            foreach (string sb in sbs)
            {
                para = new SqlParameter[]
                {
                    new SqlParameter("@CatagoryId", catagory), //FK              
                    new SqlParameter("@Id", sb)
                };

                DBHelper.ExecuteCommand(para);
            }

        }
        /// <summary>
        /// ΪЧ���������ӵķ���
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="catagory"></param>
        /// <returns></returns>
        public static void ModifyBook(string ids, string catagory)
        {
            DBHelper.ExecuteCommand("update Books set CategoryId=" + catagory + " where id in(" + ids + ")");
        }
        #endregion
    }
}
