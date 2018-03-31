using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyAirTicket.Model;

namespace MyAirTicket.DAL
{
    public class CityInfoService
    {
        //得到所有城市信息
        public List<CityInfo> GetAll()
        {
            string strsql = "select * from CityInfo";
            return GetInfoBySql(strsql);
        }
        //根据id查询城市
        public List<CityInfo> GetCityBypid(int pid)
        {
            string strsql = "select * from CityInfo where ProviceId=" + pid;
            return GetInfoBySql(strsql);
        }
        public CityInfo GetCityByid(int id)
        {
            string strsql = "select * from CityInfo where CityId=" + id;
            return GetInfoBySql(strsql)[0];
        }
        //定义私有方法获取信息
        private static List<CityInfo> GetInfoBySql(string strsql)
        {
            List<CityInfo> list = new List<CityInfo>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                CityInfo city = new CityInfo();
                city.CityId = Convert.ToInt32(row["CityId"]);
                city.CityName = row["CityName"].ToString();
                city.ProviceId = Convert.ToInt32(row["ProviceId"]);
                list.Add(city);
            }
            return list;
        }
    }
}
