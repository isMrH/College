using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.Model;
using System.Data;

namespace Mobile.DAL
{
    public class BrandService
    {
        public static int InsertBrand(User u)
        {
            string strsql = string.Format("insert into MobileBrand values('{0}','{1}')",u.Name,u.Remark);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static bool IsExists(string name)
        {
            string strsql = string.Format("select count(*) from MobileBrand where BrandName='{0}'",name);
            int cnt = Convert.ToInt32(DBHelper.GetScaler(strsql));
            if (cnt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int UpdateBrand(User u)
        {
            string strsql = string.Format("update mobilebrand set brandname='{0}' remark='{1}' where bid='{2}'",u.Name,u.Remark,u.BID);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static List<User> GetALLBrand()
        {
            string strsql = "select * from mobilebrand";
            DataTable dt = DBHelper.GetTable(strsql);

            List<User> allBrand = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                User b = new User();
                b.BID = Convert.ToInt32(row["bid"]);
                b.Name = row["brandname"].ToString();
                b.Remark = row["remark"].ToString();
                allBrand.Add(b);
            }
            return allBrand;
        }
        public static int DeleteBrand(string bid)
        {
            string strsql ="delete from mobilebrand where bid="+bid;
            return DBHelper.ExecuteCommand(strsql);
        }
    }
}
