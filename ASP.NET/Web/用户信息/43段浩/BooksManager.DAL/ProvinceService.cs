using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.Model;
using System.Data.SqlClient;
using System.Data;
namespace BooksManager.DAL
{
    public class ProvinceService
    {
        public static List<Province> GetAllProvinces()
        {
            string sql = "select * from province";
            List<Province> pr = new List<Province>();
            DataTable dt = DBHelper.GetTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                Province prov = new Province();
                prov.ProvinceId = (int)row["provinceId"];
                prov.ProvinceName = (string)row["ProvinceName"];
                pr.Add(prov);
            }
            return pr;
        }
    }
}
