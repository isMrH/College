using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthTypeItemDB.Medol;
using System.Data;
using System.Data.SqlClient;

namespace HealthTypeItemDB.DAL
{
    public class HealthItemListService
    {
        public static HealthItemList GetAllHealthItemListByid(int ItemListld)
        {
            string strsql = "select * from HealthItemList where ItemListld=" + ItemListld;
            return HealthItemListService.GetAllHealthItemListBySql(strsql)[0];
        }
        public static List<HealthItemList> GetAllHealthItemList()
        {
            string strsql = "select * from HealthItemList";
            return HealthItemListService.GetAllHealthItemListBySql(strsql);

        }
        private static List<HealthItemList> GetAllHealthItemListBySql(string strsql)
        {
            DataTable dt = DBHelper.GetTable(strsql);
            List<HealthItemList> AllHealthItemList = new List<HealthItemList>();
            foreach (DataRow row in dt.Rows)
            {
                HealthItemList hl = new HealthItemList();
                hl.ItemListld = Convert.ToInt32(row["ItemListld"]);
                hl.ItemListName = row["ItemListName"].ToString();
                hl.ItemTypeld = Convert.ToInt32(row["ItemListld"]);
                string iss = row["IsGood"].ToString();
                if (iss == "True")
                {
                    hl.IsGood = "是";
                }
                else
                {
                    hl.IsGood = "否";
                }
                hl.Price = Convert.ToDouble(row["Price"]);
                hl.Standard = row["Standard"].ToString();
                hl.Info = row["Info"].ToString();
                hl.Heath = HealthTypeItemService.GetHealthTypeItemByID(Convert.ToInt32(row["ItemTypeld"]));
                AllHealthItemList.Add(hl);
            }
            return AllHealthItemList;
        }
        //更新语句
        public static int updatelist(int ItemListld, string name, string IsGood, string Standard, double Price, string Info)
        {
            string strsql = "update HealthItemList set ItemListName='" + name + "',IsGood=" + IsGood + ",Standard='" + Standard + "',Price=" + Price + ",Info='" + Info + "' where ItemListld=" + ItemListld + "";
            return DBHelper.ExecuteCommand(strsql);
        }
    }
}
