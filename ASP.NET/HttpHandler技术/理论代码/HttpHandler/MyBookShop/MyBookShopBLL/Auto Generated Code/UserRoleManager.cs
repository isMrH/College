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

    public static partial class UserRoleManager
    {
        public static UserRole AddUserRole(UserRole userRole)
        {
            return UserRoleService.AddUserRole(userRole);
        }

        public static void DeleteUserRole(UserRole userRole)
        {
            UserRoleService.DeleteUserRole(userRole);
        }

        public static void DeleteUserRoleById(int id)
        {
            UserRoleService.DeleteUserRoleById(id);
        }

		public static void ModifyUserRole(UserRole userRole)
        {
            UserRoleService.ModifyUserRole(userRole);
        }
        
        public static IList<UserRole> GetAllUserRoles()
        {
            return UserRoleService.GetAllUserRoles();
        }

        public static UserRole GetUserRoleById(int id)
        {
            return UserRoleService.GetUserRoleById(id);
        }

        public static UserRole GetDefaultUserRole()
        {
			return GetUserRoleById(1);
        }
    }
}
