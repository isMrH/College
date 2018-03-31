using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.DAL;
using MyBlog.Model;

namespace MyBlog.BLL
{
    public class UserManagers
    {
        public static bool IsRegisteUser(string name, string pwd)
        {
            return UserService.IsRegisteUser(name, pwd);
        }
        public static int insertUser(User user)
        {
            return UserService.insertUser(user);
        }
        public static bool GetUsersName(string name)
        {
            return UserService.GetUsersName(name);
        }
    }
    
}
