using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Users.Model;

namespace Users.DAL
{
    public class UsersService
    {
        public static int InsertUser(User u)
        {
            string strsql = string.Format("insert into Users values('{0}','{1}','{2}','{3}','{4}')",u.LoginID,u.LoginPwd,u.Name,u.QQ,u.Email);
            return DBHelper.ExecuteCommand(strsql);
        }
        public static object GetScaler(string loginID)
        {
            string strsql = string.Format("select count(*) from Users where loginid='{0}'",loginID);
            object obj=DBHelper.GetScaler(strsql);
            return obj;
        }
    }
}
