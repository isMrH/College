using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Users.DAL;
using Users.Model;

namespace Users.BLL
{
    public class UsersManager
    {
        public static int InsertUser(User u)
        {
            return UsersService.InsertUser(u);
        }
        public static object GetScaler(string loginID)
        {
            return UsersService.GetScaler(loginID);
        }
    }
}
