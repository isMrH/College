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
        BookService bs = new BookService();
        public Book Getbookisbn(string isbn)
        {
            return bs.Getbookisbn(isbn);
        }
        //查询是否有符合该isbn号的记录
        public int IsHasInfo(string isbn)
        {
            return bs.IsHasInfo(isbn);
        }
        //查询所有图书信息
        public List<Book> GetAllBooks()
        {
            return bs.GetAllBooks();
        }
        //根据数量查询图书信息
        public List<Book> Getbooknumber(int number)
        {
           return bs.Getbooknumber(number);
        }
        //根据id查询图书信息
        public Book GetbookisByid(int id)
        {
            return bs.GetbookisByid(id);
        }
        //根据类别查询图书信息
        public IList<Book> GetBooksByTypeid(int categoryId, string order)
        {
            return bs.GetBooksByTypeid(categoryId, order);
        }
        //自动补全
        public string[] GetHotSearchKeyWords(string prefixText, int count)
        {
            return bs.GetHotSearchKeyWords(prefixText, count);
        }
        //根据类型id获得
        public List<Book> GetBooksByCategoryId(int id)
        {
            return bs.GetBooksByCategoryId(id);
        }
    }
}
