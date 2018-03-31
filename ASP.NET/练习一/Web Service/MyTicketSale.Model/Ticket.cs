using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTicketSale.Model
{
    public class Ticket
    {
        //火车票实体类
        public int TicketId { get; set; }
        public string TrainNo { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public int UnitPrice { get; set; }
        public int Num { get; set; }
        public int Type { get; set; }
        public string StartTime { get; set; }
    }
}
