using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySchool.Model;

namespace MySchool.DAL
{
    public class NewsTypeService
    {
        public static List<NewsType> GetAllNewsTypes()
        {
            string strsql = "select * from newstype";
            return GetNewsTypesBySql(strsql);
        }

        public static NewsType GetNewsTypeByTypeId(int typeId)
        {
            string sql = "select * from newstype where typeid=" + typeId;
            List<NewsType> alltype = GetNewsTypesBySql(sql);
            return alltype[0];
        }

        private static List<NewsType> GetNewsTypesBySql(string strsql)
        {
            List<NewsType> list = new List<NewsType>();

            DataTable table = DBHelper.GetTable(strsql);

            foreach (DataRow row in table.Rows)
            {
                NewsType nt = new NewsType();
                nt.TypeId = Convert.ToInt32(row["typeid"]);
                nt.Title = row["title"].ToString();
                nt.Remark = row["remark"].ToString();

                list.Add(nt);
            }
            return list;
        }

        public static
    }
}
