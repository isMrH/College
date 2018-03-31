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
        CategoryService cs = new CategoryService();
        //根据id查询图书类型
        public Category GetCategoriesByID(int id)
        {
            return cs.GetCategoriesByID(id);
        }
        //得到所有类型
        public List<Category> GetAll()
        {
            return cs.GetAll();
        }
    }
}
