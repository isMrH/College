using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Model;
using System.Data;
using System.Data.SqlClient;

namespace HotelManager.DAL
{
    public class RoomTypeService
    {
        private static List<RoomType> GetAllRoomTypeBySql(string strsql)
        {
            List<RoomType> list = new List<RoomType>();

            DataTable table = DBHelper.GetTable(strsql);

            foreach (DataRow row in table.Rows)
            {
                RoomType rt = new RoomType();
                rt.TypeID = Convert.ToInt32(row["typeid"]);
                rt.TypeName = row["TypeName"].ToString();
                rt.TypePrice =Convert.ToInt32(row["TypePrice"]);
                rt.AddBedPrice =Convert.ToInt32(row["AddBedPrice"]);
                rt.IsAddBed = row["IsAddBed"].ToString();
                rt.Remark = row["remark"].ToString();
                
                list.Add(rt);
            }
            return list;
        }
        //获取全部房间类型
        public static List<RoomType> GetAllRoomType()
        {
            string strsql="select * from RoomType";
            return GetAllRoomTypeBySql(strsql);
        }
        public static void DeleteRoomTypeByTypeID(int TypeID)
        {
            string strsql = "delete RoomType where TypeID=@TypeID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@TypeID",TypeID)
                };
                DBHelper.ExecuteCommand(strsql, para);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                throw e;
            }
        }
        //获取房间类型信息
        public static RoomType GetRoomTypeByTypeID(int TypeID)
        {
            string strsql = "select * from RoomType where TypeID=@TypeID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@TypeID",TypeID)
                };
                return GetAllRoomTypeBySql(strsql)[0];
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                throw e;
            }

        }
        //获取该房间类型的房间数目
        public static object GetScalarRoomByTypeID(int TypeID)
        {
            string strsql = "select count(*) from Room where TypeID=@TypeID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@TypeID",TypeID)
                };
                object obj;
                return obj=DBHelper.GetScalar(strsql, para);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                throw e;
            }
        }

        //添加房间类型
        public static int InsertRoomType(RoomType rt)
        {
            string strsql = "insert into roomtype(typename,typeprice,isaddbed,addbedprice,remark) values(@typename,@typeprice,@isaddbed,@addbedprice,@remark)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@typename",rt.TypeName),
                new SqlParameter("@typeprice",rt.TypePrice),
                new SqlParameter("@isaddbed",rt.IsAddBed),
                new SqlParameter("@addbedprice",rt.AddBedPrice),
                new SqlParameter("@remark",rt.Remark)
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
        //修改房间类型
        public static int UpdateRoomType(RoomType rt)
        {
            string strsql = "update roomtype set typeprice=@typeprice,isaddbed=@isaddbed,addbedprice=@addbedprice,remark=@remark where typeid=@typeid";
            SqlParameter[] paras = new SqlParameter[]{
            
                new SqlParameter("@typeprice",rt.TypePrice),
                new SqlParameter("@isaddbed",rt.IsAddBed),
                new SqlParameter("@addbedprice",rt.AddBedPrice),
                new SqlParameter("@typeid",rt.TypeID),
                new SqlParameter("@remark",rt.Remark)
            };
            return DBHelper.ExecuteCommand(strsql, paras);
        }
    }
}
