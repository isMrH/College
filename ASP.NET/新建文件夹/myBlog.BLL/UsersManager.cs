using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myBlog.DAL;
namespace myBlog.BLL
{
    public class UsersManager
    {
        public static bool IsRegisteUser(string name, string pwd)
        {
            return UsersService.IsRegisteUser(name, pwd);
        }
    }
}
