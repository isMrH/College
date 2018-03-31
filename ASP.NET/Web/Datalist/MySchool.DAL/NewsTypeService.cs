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
        public static NewsType GetAllTypeByTypeId(int typeid)
        {
            string strsql = "select * from newstype where typeid=" + typeid;

            List<NewsType> types = GetTypeBySql(strsql);

            return types[0];
        }

        public static List<NewsType> GetTypeBySql(string strsql)
        {
            List<NewsType> types = new List<NewsType>();

            DataTable dt = DBHelper.GetTable(strsql);

            foreach (DataRow row in dt.Rows)
            {
                NewsType type = new NewsType();

                type.Typeid = (int)row["typeid"];
                type.Title = row["title"].ToString();
                type.Remark = row["remark"].ToString();

                types.Add(type);
            }

            return types;
        }

        public static List<NewsType> GetAllType()
        {
            string strsql = "select * from NewsType";

            return GetTypeBySql(strsql);
        }
    }
}
