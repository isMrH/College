//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:18
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class BookManager
    {
        public static Book AddBook(Book book)
        {
            return BookService.AddBook(book);
        }

        public static void DeleteBook(Book book)
        {
            BookService.DeleteBook(book);
        }

        public static void DeleteBookById(int id)
        {
            BookService.DeleteBookById(id);
        }

		public static void ModifyBook(Book book)
        {
            BookService.ModifyBook(book);
        }
        
        public static IList<Book> GetAllBooks()
        {
            return BookService.GetAllBooks();
        }

        public static Book GetBookById(int id)
        {
            return BookService.GetBookById(id);
        }

    }
}
