using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class BookManager
    {
        #region 查
        /// <summary>
        /// 查询图书列表
        /// 包含了分类的查询
        /// 和有无排序的条件
        /// </summary>
        /// <param name="categoryId">查询条件：分类。小于1时代表不分类</param>
        /// <param name="order">排序条件，为空则不排序</param>
        /// <returns></returns>
        public static IList<Book> GetSmallBooks(int categoryId, string order)
        {
            return BookService.GetSmallBooks(categoryId, order);
        }

        public static IList<Book> GetBooks(string field,int categoryId, string order)
        {            
            return BookService.GetBooks(field,categoryId, order);
        }
        #region 过时的
        /*
        /// <summary>
        /// 获取较少字段内容的图书列表（不带简介）
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        [Obsolete]
        public static IList<Book> GetListBooks(int categoryId, string order)
        {
            //组合的sql语句
            string condition = "";
            if (categoryId > 0)
                condition = " WHERE CategoryId = " + categoryId;
            if (order.Trim().Length > 0)
                condition = " order by " + order;
            return BookService.GetBooks(" Id, Title, Author, PublisherId, PublishDate, UnitPrice ", condition);
        }
        /// <summary>
        /// 获取较多字段内容的图书列表（带简介）
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        [Obsolete]
        public static IList<Book> GetListBooksLarge(int categoryId, string order)
        {
            //组合的sql语句
            string condition = "";
            if (categoryId > 0)
                condition = " WHERE CategoryId = " + categoryId;
            if (order.Trim().Length > 0)
                condition = " order by " + order;
            return BookService.GetBooks(" Id, Title,PublisherId,ISBN, Author,SubString(ContentDescription,0,200) as ShortContent, UnitPrice ", condition);
        }
        */
        #endregion
        #endregion
        #region 改
        /// <summary>
        /// 更新图书的分类
        /// </summary>
        /// <param name="sbs"></param>
        /// <param name="catagory"></param>
        /// <returns></returns>
        public static void ModifyBook(string[] sbs, string catagory)
        {
            BookService.ModifyBook(sbs, catagory);
        }
        /// <summary>
        /// 更新图书分类
        /// </summary>
        /// <param name="sbs"></param>
        /// <param name="catagory"></param>
        /// <returns></returns>
        public static void ModifyBook(string ids, string catagory)
        {
            BookService.ModifyBook(ids, catagory);
        }
        /// <summary>
        /// 专为图书修改页提供的图书更新
        /// </summary>
        /// <param name="title"></param>
        /// <param name="Publisherid"></param>
        /// <param name="WordsCount"></param>
        /// <param name="AurhorDescription"></param>
        /// <param name="UnitPrice"></param>
        /// <param name="author"></param>
        /// <param name="TOC"></param>
        /// <param name="PublishDate"></param>
        /// <param name="ContentDescription"></param>
        /// <param name="editorComment"></param>
        /// <param name="id"></param>
        public static void ModifyBook(string title, int Publisherid, int WordsCount, string AurhorDescription, decimal UnitPrice, string author, string TOC, DateTime PublishDate, string ContentDescription, string editorComment, int id)
        {
            Book book = BookService.GetBookById(id);
            book.Title = title;
            book.UnitPrice = UnitPrice;
            book.Author = author;
            book.TOC = TOC;
            book.Publisher = PublisherService.GetPublisherById(Publisherid);
            book.WordsCount=WordsCount;
            book.AurhorDescription = AurhorDescription;
            book.PublishDate = PublishDate;
            book.ContentDescription = ContentDescription;
            book.EditorComment = editorComment;
            BookService.ModifyBook(book);
        }
        #endregion
        #region 增
        /// <summary>
        /// 专为图书修改页提供的添加图书
        /// </summary>
        /// <param name="title"></param>
        /// <param name="isbn"></param>
        /// <param name="Publisherid"></param>
        /// <param name="WordsCount"></param>
        /// <param name="AurhorDescription"></param>
        /// <param name="UnitPrice"></param>
        /// <param name="author"></param>
        /// <param name="TOC"></param>
        /// <param name="PublishDate"></param>
        /// <param name="ContentDescription"></param>
        /// <param name="editorComment"></param>
        public static void AddBook(string title,string isbn, int Publisherid, int WordsCount, string AurhorDescription, decimal UnitPrice, string author, string TOC, DateTime PublishDate, string ContentDescription, string editorComment)
        {
            Book book = new Book();
            book.Category = CategoryService.GetCategoryById(1);
            book.Title = title;
            book.ISBN = isbn;
            book.UnitPrice = UnitPrice;
            book.Author = author;
            book.TOC = TOC;
            book.Publisher = PublisherService.GetPublisherById(Publisherid);
            book.WordsCount = WordsCount;
            book.AurhorDescription = AurhorDescription;
            book.PublishDate = PublishDate;
            book.ContentDescription = ContentDescription;
            book.EditorComment = editorComment;
            book.Clicks = 0;
            BookService.AddBook(book);
        }
        #endregion
    }
}
