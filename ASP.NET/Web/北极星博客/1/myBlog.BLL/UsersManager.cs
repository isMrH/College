using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myBlog.DAL;
using myBlog.Model;
namespace myBlog.BLL
{
    public class UsersManager
    {
        public static bool IsRegisteUser(string name, string pwd)
        {
            return UsersService.IsRegisteUser(name, pwd);
        }
        public static int insertUser(Users user)
        {
            return UsersService.insertUser(user);
        }
        public static bool GetUsersName(string name)
        {
            return UsersService.GetUsersName(name);
        }
    }
}
