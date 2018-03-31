using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Model;
using System.Data;
using System.Data.SqlClient;


namespace MySchool.DAL
{
    public class NewsTypeService
    {
        public static NewsType GetNewsTypeByTypeId(int typeId)
        {
            string sql = "select * from NewsType where typeid=" + typeId;
            List<NewsType> types = GetNewsTypeBySql(sql);
            return types[0];
        }

        private static List<NewsType> GetNewsTypeBySql(string sql)
        {
            List<NewsType> list = new List<NewsType>();

            DataTable dt = DBHelper.GetTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                NewsType newstypes = new NewsType();

                newstypes.TypeId = (int)row["TypeId"];
                newstypes.Title = row["Title"].ToString();
                newstypes.Remark = row["Remark"].ToString();
                list.Add(newstypes);
            }
            return list;
        }
    }
}
