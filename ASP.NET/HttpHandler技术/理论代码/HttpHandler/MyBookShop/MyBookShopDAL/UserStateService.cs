using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{    
	public static partial class UserStateService
	{
        public static UserState GetNormalUserState()
        {
            return GetUserStateById(1);
        }

	}
}
