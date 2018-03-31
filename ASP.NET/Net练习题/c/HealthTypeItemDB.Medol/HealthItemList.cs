using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthTypeItemDB.Medol
{
     public class HealthItemList
    {
         public int ItemListld { get; set; }
         public string ItemListName { get; set; }
         public int ItemTypeld { get; set; }
         public string IsGood { get; set; }
         public string Standard { get; set; }
         public double Price { get; set; }
         public string Info { get; set; }
         public HealthTypeItem Heath { get; set; }
    }
}
