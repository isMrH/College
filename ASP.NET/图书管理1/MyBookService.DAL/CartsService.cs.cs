using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyBook.Model;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class CartsService
    {
        public List<Carts> GetAllInfo(string Loginid)
        {
            string strsql = "select * from Cart where UserId='" + Loginid + "'";
            return GetCartsBySql(strsql);
        }
        public int IsHasInfo(string bookName, string userid)
        {
            string strsql = "select count(*) from Cart where UserId=@userid and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@bookname",bookName),
               new SqlParameter("@userid",userid),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql, paras));
        }
        public int SelectCount(string bookName, string userid)
        {
            string strsql = "select BookCount from Cart where UserId=@userid and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@bookname",bookName),
               new SqlParameter("@userid",userid),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql, paras));
        }
        public int UpdateCount(int count, string id, string bookname)
        {
            string strsql = "update Cart set BookCount=@count where UserId=@id and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@count",count),
               new SqlParameter("@id",id),
               new SqlParameter("@bookname",bookname),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        
        public int AddInfo(Carts cart)
        {
            string strsql = "insert into Cart values(@userid,@BookName,@BookImage,@BookCount,@BookPrice)";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@userid",cart.UserId),
               new SqlParameter("@BookImage",cart.BookImage),
               new SqlParameter("@BookName",cart.BookName),
               new SqlParameter("@BookCount",cart.BookCount),
               new SqlParameter("@BookPrice",cart.BookPrice),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        
        public int DeleteById(string name, string id)
        {
            string strsql = "delete from Cart where UserId=@id and BookName=@name";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@id",id),
               new SqlParameter("@name",name),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        
        public void DeleteInfo(string loginid)
        {
            string strsql = "delete from Cart where UserId=@loginid";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@loginid",loginid),
            };
            DBHelper.ExecuteCommand(strsql, paras);
        }
        private static List<Carts> GetCartsBySql(string strsql)
        {
            List<Carts> list = new List<Carts>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Carts ct = new Carts();
                ct.Id = Convert.ToInt32(row["ID"]);
                ct.BookName = row["BookName"].ToString();
                ct.BookImage = row["BookImage"].ToString();
                ct.BookCount = Convert.ToInt32(row["BookCount"]);
                ct.BookPrice = Convert.ToDouble(row["BookPrice"]);
                ct.UserId = row["UserId"].ToString();
                list.Add(ct);
            }

            return list;
        }
    }
}
