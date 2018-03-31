using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelManager.Model;

namespace HotelManager.DAL
{
    public class TypeService
    {
        public static int InsertType(RoomType rt)
        {
            string strsql = string.Format("insert into RoomType values('{0}','{1}','{2}','{3}','{4}')",rt.TypeName,rt.TypePrice,rt.IsAddBed,rt.AddBedPrice,rt.Remark);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int UpdateType(RoomType rt)
        {
            string strsql = string.Format("update RoomType set TypeName='{0}', TypePrice='{1}', IsAddBed='{2}', AddBedPrice='{3}', Remark='{4}'where TypeId='{5}'", rt.TypeName, rt.TypePrice, rt.IsAddBed, rt.AddBedPrice, rt.Remark,rt.TypeId);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int DeleteType(int TypeId)
        {
            string strsql = "delete from RoomType where TypeId=" + TypeId;
            return DBHelper.ExecuteCommand(strsql);
        }
        public static bool IdExitRoomByTypeId(int TypeId)
        {
            string strsql = "select count(*) from room where typeid=" + TypeId;
            Object obj=DBHelper.GetScaler(strsql);
            int cnt=Convert.ToInt32(obj);
            if (cnt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int GetTypeByID(int TypeID)
        {
            string strsql = "select typeprice from roomtype where typeid=" + TypeID;
            object obj = DBHelper.GetScaler(strsql);
            int price=Convert.ToInt32(obj);
            return price;
        }
     
        public static List<RoomType> SelectType(string TypeName)
        {
            string strsql = string.Format("select * from RoomType where TypeName='{0}'", TypeName);
            List<RoomType> selecttype = new List<RoomType>();
            DataTable dt = DBHelper.GetTable(strsql);

            List<RoomType> allType = new List<RoomType>();
            foreach (DataRow row in dt.Rows)
            {
                RoomType rt = new RoomType();
                rt.TypeId = Convert.ToInt32(row["typeid"]);
                rt.TypeName = row["TypeName"].ToString();
                rt.TypePrice = Convert.ToInt32(row["TypePrice"]);
                rt.IsAddBed = row["IsAddBed"].ToString();
                rt.AddBedPrice = Convert.ToInt32(row["AddBedPrice"]);
                rt.Remark = row["Remark"].ToString();
                selecttype.Add(rt);
            }
            return selecttype;
        }
        
        public static List<RoomType> GetALLType()
        {
            string strsql = "select * from RoomType";
            DataTable dt = DBHelper.GetTable(strsql);

            List<RoomType> allType = new List<RoomType>();
            foreach (DataRow row in dt.Rows)
            {
                RoomType rt = new RoomType();
                rt.TypeId = Convert.ToInt32(row["typeid"]);
                rt.TypeName = row["TypeName"].ToString();
                rt.TypePrice = Convert.ToInt32(row["TypePrice"]);
                rt.IsAddBed = row["IsAddBed"].ToString();
                rt.AddBedPrice = Convert.ToInt32(row["AddBedPrice"]);
                rt.Remark = row["Remark"].ToString();
                allType.Add(rt);
            }
            return allType;
        }
    }
}
