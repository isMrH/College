using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAirTicket.Model;
using MyAirTicket.DAL;

namespace MyAirTicket.BLL
{
    public class TicketManager
    {
        TicketService ts = new TicketService();
        //查询
        public List<Ticket> GetTicketByFilter(int fromCity, int toCity, string leaveDate)
        {
            return ts.GetTicketByFilter(fromCity, toCity, leaveDate);
        }
    }
}
