﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Model;
using HotelManager.DAL;

namespace HotelManager.BLL
{
    public class RoomTypeManager
    {
        public static List<RoomType> GetAllRoomType()
        {
            return RoomTypeService.GetAllRoomType();
        }
        public static void DeleteRoomTypeByTypeID(int TypeID)
        {
            RoomTypeService.DeleteRoomTypeByTypeID(TypeID);
        }
        public static object GetScalarRoomByTypeID(int TypeID)
        {
            return RoomTypeService.GetScalarRoomByTypeID(TypeID);
        }
        public static RoomType GetRoomTypeByTypeID(int TypeID)
        {
            return RoomTypeService.GetRoomTypeByTypeID(TypeID);
        }
        public static int InsertRoomType(RoomType rt)
        {
            return RoomTypeService.InsertRoomType(rt);
        }
        public static int UpdateRoomType(RoomType rt)
        {
            return RoomTypeService.UpdateRoomType(rt);
        }

    }
}
