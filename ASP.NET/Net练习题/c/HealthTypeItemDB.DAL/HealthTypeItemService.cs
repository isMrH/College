using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HealthTypeItemDB.Medol;

namespace HealthTypeItemDB.DAL
{
     public  class HealthTypeItemService
    {
         //根据id查询
         public static HealthTypeItem GetHealthTypeItemByID(int ItemTypeld)
         {
             string strsql = "select * from HealthTypeItem where ItemTypeld=" + ItemTypeld;
             return HealthTypeItemService.GetHealthTypeItemBySql(strsql)[0];
         }
         //私有方法
         private static List<HealthTypeItem> GetHealthTypeItemBySql(string strsql)
         { 
             DataTable dt=DBHelper.GetTable(strsql);
             List<HealthTypeItem> allhealthTypeItem=new List<HealthTypeItem>();
             foreach(DataRow row in dt.Rows)
             {
                 HealthTypeItem ht = new HealthTypeItem();
                 ht.ItemTypeld = Convert.ToInt32(row["ItemTypeld"]);
                 ht.ItemTypeName = row["ItemTypeName"].ToString();
                 allhealthTypeItem.Add(ht);
             }
             return allhealthTypeItem;
         
         }
          
    }
}
