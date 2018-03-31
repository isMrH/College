using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAirTicket.DAL;
using MyAirTicket.Model;

namespace MyAirTicket.BLL
{
    public class CityInfoManager
    {
        CityInfoService cs = new CityInfoService();
        //根据pid查询城市
        public List<CityInfo> GetCityBypid(int pid)
        {
            return cs.GetCityBypid(pid);
        }
        public CityInfo GetCityByid(int id)
        {
            return cs.GetCityByid(id);
        }
        //得到所有城市
        public List<CityInfo> GetAll()
        {
            return cs.GetAll();
        }
    }
}
