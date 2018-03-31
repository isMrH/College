using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelManager.Model;

namespace HotelManager.DAL
{
    public class RoomService
    {
        public static int InsertRoom(Room r)
        {
            string strsql = string.Format("insert into Room values('{0}','{1}','{2}','{3}','{4}','{5}')", r.RoomNumber, r.BedNumber, r.Description, r.State, r.GuestNumber, r.TypeId);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int UpdateRoom(Room r)
        {
            string strsql = string.Format("update Room set RoomNumber='{0}', BedNumber='{1}', State='{2}', GuestNumber='{3}', TypeId='{4}'where RoomID='{5}'", r.RoomNumber, r.BedNumber, r.Description, r.State, r.GuestNumber, r.RoomId);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static int DeleteRoom(int RoomId)
        {
            string strsql = "delete from Room where RoomId=" + RoomId;
            return DBHelper.ExecuteCommand(strsql);
        }
        public static RoomType GetRoomByTypeId(int TypeId)
        {
            string strsql = "select * from roomtype where typeid=" + TypeId;
            DataTable dt = DBHelper.GetTable(strsql);
            DataRow row = dt.Rows[0];
            RoomType rt = new RoomType();
            rt.TypeName = row[1].ToString();
            rt.TypePrice = Convert.ToInt32(row[2]);
            return rt;
        }
        public static List<Room> SelectRoom(string RoomNumber)
        {
            string strsql = string.Format("select * from Room where RoomNumber='{0}'", RoomNumber);
            return Room(strsql);
        }
        public static List<Room> GetALLRoom()
        {
             string strsql= string.Format("select * from Room");
             return Room(strsql);
         }
        public static List<Room> Room(string strsql)
        {
            List<Room> selecttype = new List<Room>();
            DataTable dt = DBHelper.GetTable(strsql);

            List<Room> Room = new List<Room>();
            foreach (DataRow row in dt.Rows)
            {
                Room r = new Room();
                r.RoomId = Convert.ToInt32(row["RoomId"]);
                r.RoomNumber = Convert.ToInt32(row["RoomNumber"]);
                r.BedNumber = Convert.ToInt32(row["BedNumber"]);
                r.State = row["State"].ToString();
                r.GuestNumber = Convert.ToInt32(row["GuestNumber"]);
                r.Description = row["Description"].ToString();
                r.TypeId = Convert.ToInt32(row["TypeId"]);
                Room.Add(r);
            }
            return Room;
        }       
       
    }
}
