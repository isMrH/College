using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAirTicket.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyAirTicket.DAL
{
    public class TicketService
    {
        //根据条件查询
        public List<Ticket> GetTicketByFilter(int fromCity, int toCity, string leaveDate)
        {
            string strsql = "select * from Ticket where FromCity = '" + fromCity + "' and ToCity='" + toCity + "' and LeaveDate='" + leaveDate + "'";
            return GetInfoBySql(strsql);
        }
        //定义私有方法获取信息
        private static List<Ticket> GetInfoBySql(string strsql)
        {
            List<Ticket> list = new List<Ticket>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                CityInfoService cs = new CityInfoService();
                Ticket ticekt = new Ticket();
                ticekt.TicketID = Convert.ToInt32(row["TicketId"]);
                ticekt.FlightOrder =row["FlightOrder"].ToString();
                ticekt.FromCity = cs.GetCityByid(Convert.ToInt32( row["FromCity"])).CityName;
                ticekt.ToCity = cs.GetCityByid(Convert.ToInt32( row["ToCity"])).CityName;
                ticekt.Price = Convert.ToInt32(row["Price"]);
                ticekt.LeaveDate = row["LeaveDate"].ToString();
                ticekt.RoomType = row["RoomType"].ToString();
                if (ticekt.RoomType == "1")
                {
                    ticekt.RoomType = "经济舱";
                }
                if (ticekt.RoomType == "2")
                {
                    ticekt.RoomType = "头等舱";
                }
                if (ticekt.RoomType == "3")
                {
                    ticekt.RoomType = "豪华舱";
                }
                list.Add(ticekt);
            }
            return list;
        }
    }
}
