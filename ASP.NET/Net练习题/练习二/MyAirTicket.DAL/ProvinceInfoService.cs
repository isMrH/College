using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyAirTicket.Model;

namespace MyAirTicket.DAL
{
    public class ProvinceInfoService
    {
        //得到所有省份信息
        public List<ProvinceInfo> GetAllInfo()
        {
            string strsql = "select * from ProvinceInfo";
            return GetInfoBySql(strsql);
        }
        //定义私有方法获取信息
        private static List<ProvinceInfo> GetInfoBySql(string strsql)
        {
            List<ProvinceInfo> list = new List<ProvinceInfo>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                ProvinceInfo provinceInfo = new ProvinceInfo();
                provinceInfo.ProviceId = Convert.ToInt32(row["ProviceId"]);
                provinceInfo.ProviceName = row["ProviceName"].ToString();
                list.Add(provinceInfo);
            }
            return list;
        }
    }
}
