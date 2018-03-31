using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class BookManager
    {
        public static Book Getbookisbn(string isbn)
        {
            return BookService.Getbookisbn(isbn);
        }
        //查询所有图书信息
        public static List<Book> GetAllBooks()
        {
            return BookService.GetAllBooks();
        }
        //根据数量查询图书信息
        public static List<Book> Getbooknumber(int number)
        {
            return BookService.Getbooknumber(number);
        }
        //根据id查询图书信息
        public static Book GetbookisByid(int id)
        {
            return BookService.GetbookisByid(id);
        }

    }
}
