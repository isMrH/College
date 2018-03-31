using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Model;

namespace HotelManager.DAL
{
    public class RoomService
    {
        //得到所有房间信息
        public  List<Room> GetAllRoom()
        {
            string strsql = "select * from room";
            return GetInfoBysql(strsql);
        }
        //查看是否重名
        public  int IsHasName(string roomnumber)
        {
            string strsql = "select count(*) from room where number=@roomnumber";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@roomnumber",roomnumber),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql, paras));
        }
        //根据客房id查询客房信息
        public  Room GetRoomById(int id)
        {
            string strsql = "select * from room where roomid=" + id;
            return GetInfoBysql(strsql)[0];
        }
        //插入数据
        public  int InsertRoomInfo(Room room)
        {
            string strsql = "insert into room(number,bednumber,Description,state,GuestNumber,typeid) values(@number,@bednumber,@description,@state,@guestnumber,@typeid)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@number",room.Number),
                new SqlParameter("@bednumber",room.BedNumber),
                new SqlParameter("@description",room.Description),
                new SqlParameter("@state",room.State),
                new SqlParameter("@guestnumber",room.GuestNumber),
                new SqlParameter("@typeid",room.TypeId),
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //修改数据
        public  int UpdateRoomInfo(Room room)
        {
            string strsql = "update room set description=@description,state=@state,guestnumber=@guestnumber,typeid=@typeid where roomid=@roomid";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@roomid",room.RoomId),
                new SqlParameter("@bednumber",room.BedNumber),
                new SqlParameter("@description",room.Description),
                new SqlParameter("@state",room.State),
                new SqlParameter("@guestnumber",room.GuestNumber),
                new SqlParameter("@typeid",room.TypeId),
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //删除数据
        public  int DelRoom(int roomid)
        {
            string strsql = "delete from room where roomid="+roomid;
            
            return DBHelper.ExecuteCommand(strsql);
        }
        public static List<Room> GetInfoBysql(string strsql)
        {
            DataTable ds = DBHelper.GetTable(strsql);

            List<Room> allroom = new List<Room>();

            foreach (DataRow r in ds.Rows)
            {
                Room room = new Room();
                room.RoomId = Convert.ToInt32(r["roomid"]);
                room.Number =(r["number"]).ToString();
                room.BedNumber = Convert.ToInt32(r["bednumber"]);
                room.State = r["state"].ToString();
                room.GuestNumber = Convert.ToInt32(r["GuestNumber"]);
                room.Description = r["Description"].ToString();
                room.TypeId = Convert.ToInt32(r["typeid"]);
                RoomTypeService rtservice = new RoomTypeService();
                room.type = rtservice.GetTypeByTypeid(Convert.ToInt32(r["typeid"]));
                allroom.Add(room);
            }
            return allroom;
        }
    }
}
