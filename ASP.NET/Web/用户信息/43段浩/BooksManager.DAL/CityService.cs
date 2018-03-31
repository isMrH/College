using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.Model;
using System.Data.SqlClient;
using System.Data;
namespace BooksManager.DAL
{
    public  class CityService
    {
        public static List<City> GetCitiesByProvinceId(int provinceId)
        {
            string sql = "select * from city where provinceId=" + provinceId;
            List<City> city = new List<City>();//创建存放城市的集合对象
            DataTable dt = DBHelper.GetTable(sql);//执行sql语句
            //将DataTable中的数据存放到集合中
            foreach (DataRow row in dt.Rows)
            {
                City City = new City();
                City.CityId = (int)row["cityId"];
                City.CityName = (string)row["cityName"];
                City.ProvinceId=(int)row["provinceId"];
                city.Add(City);

            }
            return city;
        }
    }
}
