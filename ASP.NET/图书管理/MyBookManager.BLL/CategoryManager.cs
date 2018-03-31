using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBookService.DAL;
using MyBook.Model;

namespace MyBookManager.BLL
{
    public class CategoryManager
    {
        //根据id查询图书类型
        public static Category GetCategoriesByID(int id)
        {
            return CategoryService.GetCategoriesByID(id);
        }
    }
}
