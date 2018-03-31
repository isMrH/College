using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class OrderDetailsSerivce
    {
        //根据id查询图书类型
        public List<OrderDetails> GetInfoByid(string id)
        {
            string strsql = "select * from OrderDetails where UserId='" + id + "' order by BuyDate desc";
            return GetPublishersBySql(strsql);

        }
        //往订单表中添加信息
        public int AddInfoByid(OrderDetails ods)
        {
            string strsql = "insert into OrderDetails values(@UserId,@BookImage,@BookName,@BookCount,@BookPrice,@Total,@BuyDate)";
            SqlParameter[] paras = new SqlParameter[] { 
                new SqlParameter("@UserId",ods.UserId),
                new SqlParameter("@BookImage",ods.BookImage),
                new SqlParameter("@BookName",ods.BookName),
                new SqlParameter("@BookCount",ods.BookCount),
                new SqlParameter("@BookPrice",ods.BookPrice),
                new SqlParameter("@Total",ods.Total),
                new SqlParameter("@BuyDate",ods.BuyDate),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        //删除信息
        public int DeleteInfo(string name, string id)
        {
            string strsql = "delete from OrderDetails where BookName=@name and UserId=@UserId";
            SqlParameter[] paras = new SqlParameter[] { 
                new SqlParameter("@UserId",id),
                new SqlParameter("@Name",name),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        //定义私有方法获取信息
        private static List<OrderDetails> GetPublishersBySql(string strsql)
        {
            List<OrderDetails> list = new List<OrderDetails>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                OrderDetails ods = new OrderDetails();
                ods.UserId = row["UserId"].ToString();
                ods.BookName = row["BookName"].ToString();
                ods.BookImage = row["BookImage"].ToString();
                ods.BookCount = Convert.ToInt32(row["BookCount"]);
                ods.BookPrice = Convert.ToDouble(row["BookPrice"]);
                ods.Total = Convert.ToDouble(row["Total"]);
                ods.BuyDate = Convert.ToDateTime(row["BuyDate"]);
                list.Add(ods);
            }

            return list;
        }
    }
}
