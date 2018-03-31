using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.DAL;
using HotelManager.Model;

namespace HotelManager.BLL
{
    public class TypeManager
    {
        public static int InsertType(RoomType rt)
        {
            return TypeService.InsertType(rt);
        }
        public static int UpdateType(RoomType rt)
        {
            return TypeService.UpdateType(rt);
        }
        public static int DeleteType(int TypeId)
        {
            return TypeService.DeleteType(TypeId);
        }
        public static bool IdExitRoomByTypeId(int TypeId)
        {
            return TypeService.IdExitRoomByTypeId(TypeId);
        }
        public static int GetTypeByID(int TypeID)
        {
            return TypeService.GetTypeByID(TypeID);
        }
        public static List<RoomType> SelectType(string TypeName)
        {
            return TypeService.SelectType(TypeName);
        }
        public static List<RoomType> GetALLType()
        {
            return TypeService.GetALLType();
        }
    }
}
