using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.DAL;
using HotelManager.Model;

namespace HotelManager.BLL
{
    public class RoomTypeManager
    {
        RoomTypeService rtservice = new RoomTypeService();
        //得到全部房间类型
        public  List<RoomType> GetAllType()
        {
            return rtservice.GetAllType();
        }
        //根据类型编号得到房间类型
        public  RoomType GetTypeByTypeid(int typeid)
        {
            return rtservice.GetTypeByTypeid(typeid);
        }
        //删除所选类型
        public  void DeleteTypeInfo(int typeid)
        {
            rtservice.DeleteTypeInfo(typeid);
        }
        //查看该类型是否有住房记录，如有则不能删，如没有则可以删
        public  int IsHasRoomInfo(int typeid)
        {
            return rtservice.IsHasRoomInfo(typeid);
        }
        //添加类型
        public  int InsertRoomType(RoomType rt)
        {
            return rtservice.InsertRoomType(rt);
        }
         //修改数据
        public  int UpdateRoomType(RoomType rt)
        {
            return rtservice.UpdateRoomType(rt);
        }
        //查看是否重名
        public  int IsHasName(string typename)
        {
            return rtservice.IsHasName(typename);
        }
    }
}
