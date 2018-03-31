using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 练习
{
    class FriendsOp
    {
        public static int InsertFriend(Friends f)
        {
            string strsql = string.Format("insert into friends values('{0}','{1}','{2}','{3}','{4}')", f.Name, f.Fid, f.Tel, f.Email, f.Address);
            return DBHelper.ExecuteCommand(strsql);
        }

        public static bool IxExist(string name)
        {
            string strsql = "select count(*) from friends where name='" + name + "'";
            object obj = DBHelper.GetScaler(strsql);

            int cnt = Convert.ToInt32(obj);
            if (cnt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Friends> GetFriendsByTypeId(string typeid)
        {
            List<Friends> friends = new List<Friends>();

            string strsql = "select * from friends";
            
            if(typeid!="0")
            {
                strsql += " where fid=" + typeid;
            }

            DataTable dt = DBHelper.GetTable(strsql);
            Friends friend;

            foreach (DataRow row in dt.Rows)
            {
                friend = new Friends();
                friend.Id = Convert.ToInt32(row[0]);
                friend.Name = row[1].ToString();
                friend.Fid = Convert.ToInt32(row[2]);
                friend.Tel = row[3].ToString();
                friend.Email = row[4].ToString();
                friend.Address = row[5].ToString();
                

                friends.Add(friend);
            }
            return friends;
            
        }
    }
}
