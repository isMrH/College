using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthTypeItemDB.DAL;
using HealthTypeItemDB.Medol;

namespace HealthTypeItemDB.BLL
{
    public class HealthItemListManager
    {
         public static List<HealthItemList> GetAllHealthItemList()
         {
             return HealthItemListService.GetAllHealthItemList();
         }

               //更新语句
         public static int updatelist(int ItemListld, string name,int IsGood, string Standard, double Price, string Info)
         {
             return HealthItemListService.updatelist(ItemListld, name,IsGood, Standard, Price, Info);
         }
         public static HealthItemList GetAllHealthItemListByid(int ItemListld)
         {
             return HealthItemListService.GetAllHealthItemListByid(ItemListld);
         }
    }
}
