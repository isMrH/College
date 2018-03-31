using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 联系人
{
    class LinkManTypeop
    {
        public static List<LinkManType> GetAllLinkMan(string typeid)
        {
            List<LinkManType> type = new List<LinkManType>();
            string strsql = "select * from Friends where fid"=typeid;
            DataTable dt = DBHelper.GetTable(strsql);
            LinkManType lmt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lmt= new LinkManType();
                lmt.Fid = Convert.ToInt32(dt.Rows[i][1]);
                lmt.Typename= dt.Rows[i][0].ToString();


                type.Add(lmt);
            }
            return type;
        }
    }
}
