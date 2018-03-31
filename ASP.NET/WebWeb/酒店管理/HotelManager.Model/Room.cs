using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Model
{
    public class Room
    {
        public int RoomId { get; set; }
        public string  Number { get; set; }
        public int BedNumber { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int GuestNumber { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public int TypePrice { get; set; }
        public RoomType type { get; set; }
    }
}
