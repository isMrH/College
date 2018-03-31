using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.Model;

namespace Mobile.DAL
{
    public class InfoService
    {
        public static int InsertInfo(Info info)
        {
            string strsql = string.Format("insert into mobileinfo(bid,mtype,OS,ScreenSize,Weights,DateOfListing,Unitprice,Remain,IsIntelligent) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", info.Bid, info.MType, info.OS, info.ScreenSize, info.Weights, info.DateOfListing, info.Unitprice, info.Remain, info.IsIntelligent);
            return DBHelper.ExecuteCommand(strsql);
        }
    }
}
