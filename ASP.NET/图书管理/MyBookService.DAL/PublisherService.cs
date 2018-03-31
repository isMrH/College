using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;

namespace MyBookService.DAL
{
    public class PublisherService
    {
        //根据id查询图书类型
        public static Publisher GetPublishersByID(int id)
        {


            string strsql = "select * from Publishers where ID=" + id;
            return GetPublishersBySql(strsql)[0];

        }
        //定义私有方法获取信息
        private static List<Publisher> GetPublishersBySql(string strsql)
        {
            List<Publisher> list = new List<Publisher>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Publisher pbl = new Publisher();
                pbl.id = Convert.ToInt32(row["ID"]);
                pbl.name = row["Name"].ToString();
                list.Add(pbl);
            }

            return list;
        }
    }
}
