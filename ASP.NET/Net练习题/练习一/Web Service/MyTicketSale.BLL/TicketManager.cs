using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTicketSale.Model;
using MyTicketSale.DAL;

namespace MyTicketSale.BLL
{
    
    public class TicketManager
    {
        TicketService ts = new TicketService();
        //根据条件查询信息
        public Ticket GetTicketByFilter(string trainNo, string fromplace, string toplace, int type)
        {
            return ts.GetTicketByFilter(trainNo, fromplace, toplace, type);
        }
        //查看有没有
        public int GetCount(string trainNo, string fromplace, string toplace, int type)
        {
            return ts.GetCount(trainNo, fromplace, toplace, type);
        }
    }
}
