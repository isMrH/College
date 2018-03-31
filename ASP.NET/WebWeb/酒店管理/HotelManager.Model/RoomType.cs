using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Model
{
    public class RoomType
    {
        
            public int TypeId { get; set; }
            public string TypeName { get; set; }
            public int TypePrice { get; set; }
            public string IsAddBed { get; set; }
            public int AddBedPrice { get; set; }
            public string Remark { get; set; }
        
    }
}
