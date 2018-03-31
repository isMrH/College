using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.Model;

namespace BooksManager.DAL
{
    public class UserService
    {
        public static int InsertUser(Users u)
        {
            string strsql = string.Format("insert into Users values('{0}','{1}','{2}','{3}','{4}','{5}')",u.Name,u.Password,u.Address,u.Sex,u.Favorite,u.CityID);
            return DBHelper.ExecuteCommand(strsql);
        }
         public static object GetUserByName(string name)
        {
           string strsql=string.Format("select count(*) from Users where Name='{0}'",name);
           object obj = DBHelper.GetScaler(strsql);
           return obj;
         }
    }
}
