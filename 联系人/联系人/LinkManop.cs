using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 联系人
{
    class LinkManop
    {
        public static int InsertLinkMan(LinkMan LM)
        {
            string strsql = "insert into Friends values('" + LM.Name + "','" + LM.Type + "','" + LM.Tel + "','" + LM.Email + "','" + LM.Address + "')";
            return DBHelper.ExecuteCommand(strsql);
        }

        public static List<LinkMan> GetAllLinkMan()
        {
            List<LinkMan> link = new List<LinkMan>();
            string strsql = "select * from users";
            DataTable dt = DBHelper.GetTable(strsql);
            LinkMan lm;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lm = new LinkMan();
                lm.Name = dt.Rows[i][0].ToString();
                lm.Type = Convert.ToInt32(dt.Rows[i][1]);
                lm.Tel = dt.Rows[i][2].ToString();
                lm.Email = dt.Rows[i][3].ToString();
                lm.Address = dt.Rows[i][4].ToString();

                link.Add(lm);
            }
            return link;
        }
    }
}
