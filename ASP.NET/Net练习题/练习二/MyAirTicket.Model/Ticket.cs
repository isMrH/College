using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAirTicket.Model
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string FlightOrder { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public int Price { get; set; }
        public string LeaveDate { get; set; }
        public string RoomType { get; set; }

    }
}
