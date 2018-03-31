using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelManager.Model;
using System.Data.SqlClient;

namespace HotelManager.DAL
{
    public class RoomTypeService
    {
        //得到全部房间类型
        public  List<RoomType> GetAllType()
        {
            string strsql = "select * from roomtype";
            return GetTypeBysql(strsql);

        }
        //根据类型编号得到房间类型
        public  RoomType GetTypeByTypeid(int typeid)
        {
            string strsql = "select * from roomtype where typeid="+typeid;
            return GetTypeBysql(strsql)[0];
        }
        //查看是否重名
        public  int IsHasName(string typename)
        {
            string strsql = "select count(*) from roomtype where typename=@typename";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@typename",typename),
            };
            return Convert.ToInt32( DBHelper.GetScalar(strsql, paras));
        }
        //添加类型
        public  int InsertRoomType(RoomType rt)
        {
            string strsql ="insert into roomtype(typename,typeprice,isaddbed,addbedprice,remark) values(@typename,@typeprice,@isaddbed,@addbedprice,@remark)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@typename",rt.TypeName),
                new SqlParameter("@typeprice",rt.TypePrice),
                new SqlParameter("@isaddbed",rt.IsAddBed),
                new SqlParameter("@addbedprice",rt.AddBedPrice),
                new SqlParameter("@remark",rt.Remark)
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //修改数据
        public  int UpdateRoomType(RoomType rt)
        {
            string strsql ="update roomtype set typeprice=@typeprice,isaddbed=@isaddbed,addbedprice=@addbedprice,remark=@remark where typeid=@typeid";
             SqlParameter[] paras = new SqlParameter[]{
            
                new SqlParameter("@typeprice",rt.TypePrice),
                new SqlParameter("@isaddbed",rt.IsAddBed),
                new SqlParameter("@addbedprice",rt.AddBedPrice),
                new SqlParameter("@typeid",rt.TypeId),
                new SqlParameter("@remark",rt.Remark)
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //删除所选类型
       public  void  DeleteTypeInfo(int typeid)
        {
            string strsql = "delete from roomtype where typeid=@typeid";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@typeid",typeid),
            };

            object obj = DBHelper.GetScalar(strsql, paras);
            int cnt = Convert.ToInt32(obj);
        }
        //查看该类型是否有住房记录，如有则不能删，如没有则可以删
       public  int IsHasRoomInfo(int typeid)
       {
           string strsql = "select count(*) from room where typeid=@typeid";
           SqlParameter[] paras = new SqlParameter[]{
               new SqlParameter("@typeid",typeid)
           };

           object obj = DBHelper.GetScalar(strsql, paras);
           int cnt = Convert.ToInt32(obj);
           return cnt;
       }
        public static List<RoomType> GetTypeBysql(string strsql)
        {
            DataTable ds = DBHelper.GetTable(strsql);

            List<RoomType> alltype = new List<RoomType>();

            foreach (DataRow r in ds.Rows)
            {
                RoomType rt = new RoomType();
                rt.TypeId = Convert.ToInt32(r[0]);
                rt.TypeName = r[1].ToString();
                rt.TypePrice = Convert.ToInt32(r[2]);
                rt.IsAddBed = (r[4]).ToString();
                if (r[3] != DBNull.Value)
                {
                    rt.AddBedPrice = Convert.ToInt32(r[3]);
                }
                rt.Remark = (r[5] == DBNull.Value) ? "" : r[5].ToString();

                alltype.Add(rt);
            }
            return alltype;
        } 
    }
}
