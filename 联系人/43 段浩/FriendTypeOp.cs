using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 练习
{
    class FriendTypeOp
    {
        public static List<FriendType> GetAllFridens()
        {
            List<FriendType> friendtypes = new List<FriendType>();
            string strsql = "select * from FriendType";

            DataTable dt = DBHelper.GetTable(strsql);
            FriendType friendtype;

            foreach (DataRow row in dt.Rows)
            {
                friendtype = new FriendType();
                friendtype.Fid = Convert.ToInt32(row[0]);
                friendtype.Typename = row[1].ToString();

                friendtypes.Add(friendtype);
            }
            return friendtypes;
        }
    }
}
