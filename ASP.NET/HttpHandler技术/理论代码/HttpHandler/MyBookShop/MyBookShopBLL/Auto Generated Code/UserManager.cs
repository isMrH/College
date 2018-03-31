//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class UserManager
    {
        public static User AddUser(User user)
        {
            if (user.UserState == null)
            {
                user.UserState = UserStateManager.GetDefaultUserState();
            }
			
            if (user.UserRole == null)
            {
                user.UserRole = UserRoleManager.GetDefaultUserRole();
            }
			
            return UserService.AddUser(user);
        }

        public static void DeleteUser(User user)
        {
            UserService.DeleteUser(user);
        }

        public static void DeleteUserById(int id)
        {
            UserService.DeleteUserById(id);
        }

		public static void ModifyUser(User user)
        {
            UserService.ModifyUser(user);
        }
        
        public static IList<User> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        public static User GetUserById(int id)
        {
            return UserService.GetUserById(id);
        }

    }
}
