using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAirTicket.DAL;
using MyAirTicket.Model;

namespace MyAirTicket.BLL
{
    public class ProvinceInfoManager
    {
        ProvinceInfoService ps = new ProvinceInfoService();
        //得到所有省份
        public List<ProvinceInfo> GetAllInfo()
        {
            return ps.GetAllInfo();
        }
    }
}
