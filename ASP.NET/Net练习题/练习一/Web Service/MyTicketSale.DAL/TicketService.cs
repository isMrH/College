using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTicketSale.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyTicketSale.DAL
{
    public class TicketService
    {
        //根据条件查询信息
        public Ticket GetTicketByFilter(string trainNo, string fromplace, string toplace, int type)
        {
            string strsql = "select * from Ticket where 1=1";
            if (trainNo.Trim().Length > 0)
            {
                strsql += " and TrainNo='" + trainNo + "'";
            }
            if (fromplace.Trim().Length > 0)
            {
                strsql += " and FromPlace='" + fromplace + "'";
            }
            if (toplace.Trim().Length > 0)
            {
                strsql += " and ToPlace='" + toplace + "'";
            }
            if (type > 0)
            {
                strsql += " and Type=" + type;
            }
            return GetInfoBySql(strsql)[0];
        }
        //查看有没有
        public int GetCount(string trainNo, string fromplace, string toplace, int type)
        {
            string strsql = "select count(*) from Ticket where 1=1";
            if (trainNo.Trim().Length > 0)
            {
                strsql += " and TrainNo='" + trainNo + "'";
            }
            if (fromplace.Trim().Length > 0)
            {
                strsql += " and FromPlace='" + fromplace + "'";
            }
            if (toplace.Trim().Length > 0)
            {
                strsql += " and ToPlace='" + toplace + "'";
            }
            if (type > 0)
            {
                strsql += " and Type=" + type;
            }
            return Convert.ToInt32( DBHelper.GetScalar(strsql));
        }
        //定义私有方法获取信息
        private static List<Ticket> GetInfoBySql(string strsql)
        {
            List<Ticket> list = new List<Ticket>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Ticket ticekt = new Ticket();
                ticekt.TicketId = Convert.ToInt32(row["TicketId"]);
                ticekt.TrainNo = row["TrainNo"].ToString();
                ticekt.FromPlace = row["FromPlace"].ToString();
                ticekt.ToPlace = row["ToPlace"].ToString();
                ticekt.UnitPrice = Convert.ToInt32(row["UnitPrice"]);
                ticekt.Num = Convert.ToInt32(row["Num"]);
                ticekt.Type = Convert.ToInt32(row["Type"]);
                ticekt.StartTime = row["StartTime"].ToString();
                list.Add(ticekt);
            }

            return list;
        }
    }
}
