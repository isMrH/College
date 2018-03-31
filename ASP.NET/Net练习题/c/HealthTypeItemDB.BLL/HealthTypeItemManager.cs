using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthTypeItemDB.DAL;
using HealthTypeItemDB.Medol;


namespace HealthTypeItemDB.BLL
{
    public class HealthTypeItemManager
    {
           //根据id查询
        public static HealthTypeItem GetHealthTypeItemByID(int ItemTypeld)
        {
            return HealthTypeItemService.GetHealthTypeItemByID(ItemTypeld);
        }
    }
}
