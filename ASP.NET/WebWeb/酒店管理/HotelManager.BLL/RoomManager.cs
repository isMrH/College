using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.DAL;
using HotelManager.Model;

namespace HotelManager.BLL
{
    public class RoomManager
    {
        RoomService roomservice = new RoomService();
         //得到所有房间信息
        public  List<Room> GetAllRoom()
        {
            return roomservice.GetAllRoom();
        }
         //插入数据
        public  int InsertRoomInfo(Room room)
        {
            return roomservice.InsertRoomInfo(room);
        }
        //修改数据
        public  int UpdateRoomInfo(Room room)
        {
            return roomservice.UpdateRoomInfo(room);
        }
        //删除数据
        public  int DelRoom(int roomid)
        {
            return roomservice.DelRoom(roomid);
        }
        //根据客房id查询客房信息
        public  Room GetRoomById(int id)
        {
            return roomservice.GetRoomById(id);
        }
        //查看是否重名
        public  int IsHasName(string roomnumber)
        {
            return roomservice.IsHasName(roomnumber);
        }
    }
}
