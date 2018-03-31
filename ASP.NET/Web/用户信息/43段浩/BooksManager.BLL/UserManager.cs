using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.DAL;
using BooksManager.Model;

namespace BooksManager.BLL
{
    public class UserManager
    {
        public static int InsertUser(Users u)
        {
            return UserService.InsertUser(u);
        }
        public static object GetUserByName(string name)
        {
            return UserService.GetUserByName(name);            
        }

    }
}
