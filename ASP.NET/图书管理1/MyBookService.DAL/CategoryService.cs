using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class CategoryService
    {

        //根据id查询图书类型
        public static Category GetCategoriesByID(int id)
        {
            string strsql = "select * from Categories where ID=" + id;
            return GetCategorieBySql(strsql)[0];

        }
        //定义私有方法获取信息
        private static List<Category> GetCategorieBySql(string strsql)
        {
            List<Category> list = new List<Category>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Category Cate = new Category();
                Cate.id= Convert.ToInt32(row["ID"]);
                Cate.name = row["Name"].ToString();
                list.Add(Cate);
            }

            return list;
        }
    }
}
