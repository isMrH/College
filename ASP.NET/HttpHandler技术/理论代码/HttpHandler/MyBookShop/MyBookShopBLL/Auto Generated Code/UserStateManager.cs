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

    public static partial class UserStateManager
    {
        public static UserState AddUserState(UserState userState)
        {
            return UserStateService.AddUserState(userState);
        }

        public static void DeleteUserState(UserState userState)
        {
            UserStateService.DeleteUserState(userState);
        }

        public static void DeleteUserStateById(int id)
        {
            UserStateService.DeleteUserStateById(id);
        }

		public static void ModifyUserState(UserState userState)
        {
            UserStateService.ModifyUserState(userState);
        }
        
        public static IList<UserState> GetAllUserStates()
        {
            return UserStateService.GetAllUserStates();
        }

        public static UserState GetUserStateById(int id)
        {
            return UserStateService.GetUserStateById(id);
        }

        public static UserState GetDefaultUserState()
        {
			return GetUserStateById(1);
        }
    }
}
