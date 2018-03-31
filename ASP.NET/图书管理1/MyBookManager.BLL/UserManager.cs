using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class UserManager
    {
        public static Users GetUsersByID(string username)
        {
            return UserService.GetUsersByID(username);
        }
    }
}
