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
        public static int InsertRoom(Room r)
        {
            return RoomService.InsertRoom(r);
        }
        public static int UpdateRoom(Room r)
        {
            return RoomService.UpdateRoom(r);
        }
        public static int DeleteRoom(int RoomId)
        {
            return RoomService.DeleteRoom(RoomId);
        }
        public static List<Room> SelectRoom(string RoomNumber)
        {
            return RoomService.SelectRoom(RoomNumber);
        }
        public static List<Room> GetALLRoom()
        {
            return RoomService.GetALLRoom();
        }
        public static RoomType GetRoomByTypeId(int TypeId)
        {
            return RoomService.GetRoomByTypeId(TypeId);
        }

    }
}
