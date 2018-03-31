using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class BookManager
    {

        public static string[] GetHotBooks(string title)
        {
            return BookService.GetHotBooks(title);
        }       
    }
}
