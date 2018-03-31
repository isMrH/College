using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class CartService
    {
        //得到某账户的所有信息
        public List<Carts> GetAllInfo(string Loginid)
        {
            string strsql = "select * from Cart where UserId='"+Loginid+"'";
            return GetInfoBySql(strsql);
        }
        //查看该账户中是否有这本书的信息
        public int IsHasInfo(string bookName,string userid)
        {
            string strsql = "select count(*) from Cart where UserId=@userid and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@bookname",bookName),
               new SqlParameter("@userid",userid),
            };
            return Convert.ToInt32( DBHelper.GetScalar(strsql, paras));
        }
        //查找该本书
        public Carts GetByName(string name, string userid)
        {
            string strsql = "select * from Cart where UserId='"+userid+"' and BookName='"+name+"'";
            return GetInfoBySql(strsql)[0];
        }
        //查看数量
        public int SelectCount(string bookName, string userid)
        {
            string strsql = "select BookCount from Cart where UserId=@userid and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@bookname",bookName),
               new SqlParameter("@userid",userid),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql, paras));
        }
        //修改数量
        public int UpdateCount(int count,string  id,string bookname)
        {
            string strsql = "update Cart set BookCount=@count where UserId=@id and BookName=@bookname";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@count",count),
               new SqlParameter("@id",id),
               new SqlParameter("@bookname",bookname),
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //添加信息
        public int AddInfo(Carts cart)
        {
            string strsql = "insert into Cart values(@userid,@BookImage,@BookName,@BookCount,@BookPrice)";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@userid",cart.UserId),
               new SqlParameter("@BookImage",cart.BookImage),
               new SqlParameter("@BookName",cart.BookName),
               new SqlParameter("@BookCount",cart.BookCount),
               new SqlParameter("@BookPrice",cart.BookPrice),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        //根据id删除信息
        public int DeleteById(string name ,string  id)
        {
            string strsql = "delete from Cart where UserId=@id and BookName=@name";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@id",id),
               new SqlParameter("@name",name),
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        //删除某客户的已支付图书信息
        public void DeleteInfo(string loginid)
        {
            string strsql = "delete from Cart where UserId=@loginid";
            SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@loginid",loginid),
            };
            DBHelper.ExecuteCommand(strsql, paras);
        }
        //定义私有方法获取信息
        private static List<Carts> GetInfoBySql(string strsql)
        {
            List<Carts> list = new List<Carts>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Carts cart = new Carts();
                cart.Id = Convert.ToInt32(row["Id"]);
                cart.BookImage=row["BookImage"].ToString();
                cart.BookName = row["BookName"].ToString();
                cart.BookCount = Convert.ToInt32(row["BookCount"]);
                cart.BookPrice = Convert.ToDouble(row["BookPrice"]);
                list.Add(cart);
            }

            return list;
        }
    }
}
