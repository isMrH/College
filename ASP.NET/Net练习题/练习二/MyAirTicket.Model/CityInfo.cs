using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAirTicket.Model
{
    public class CityInfo
    {
        //城市
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int ProviceId { get; set; }
        public ProvinceInfo province { get; set; }
    }
}
