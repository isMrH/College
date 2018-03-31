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

    public static partial class CategoryManager
    {
        public static Category AddCategory(Category category)
        {
            return CategoryService.AddCategory(category);
        }

        public static void DeleteCategory(Category category)
        {
            CategoryService.DeleteCategory(category);
        }

        public static void DeleteCategoryById(int id)
        {
            CategoryService.DeleteCategoryById(id);
        }

		public static void ModifyCategory(Category category)
        {
            CategoryService.ModifyCategory(category);
        }
        
        public static IList<Category> GetAllCategories()
        {
            return CategoryService.GetAllCategories();
        }

        public static Category GetCategoryById(int id)
        {
            return CategoryService.GetCategoryById(id);
        }

    }
}
