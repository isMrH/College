using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{
    public static partial class UserService
    {
        public static bool LoginIdExists(string loginId)
        {
            if (GetUserByLoginId(loginId) != null)
            { return true; }
            else
            { return false; }
                
        }

        public static IList<User> GetAllNormalUsers()
        {
            string sql = "SELECT * FROM users WHERE userstateid = 1" ;
            return GetUsersBySql(sql);
        }

        
        /// <summary>
        /// 通过登录名查找管理员
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public static User GetAdminUserByLoginId(string loginId)
        {
            string sql = "SELECT * FROM users WHERE LoginId = @LoginId and UserRoleId=@RoleId";
            int roleId;
            int userStateId;

            SqlParameter[] para = new SqlParameter[]
            {
				new SqlParameter("@LoginId", loginId), 
				new SqlParameter("@RoleId", 3)
			};
            using (SqlDataReader reader = DBHelper.GetReader(sql, para))
            {     
                if (reader.Read())
                {
                    User user = new User();
                    user.Id = (int)reader["Id"];
                    user.LoginId = (string)reader["LoginId"];
                    user.LoginPwd = (string)reader["LoginPwd"];
                    user.Name = (string)reader["Name"];
                    user.Address = (string)reader["Address"];
                    user.Phone = (string)reader["Phone"];
                    user.Mail = (string)reader["Mail"];
                    roleId = (int)reader["UserRoleId"];
                    userStateId = (int)reader["UserStateId"];
                    user.UserRole = UserRoleService.GetUserRoleById(roleId);
                    user.UserState = UserStateService.GetUserStateById(userStateId);                    
                    reader.Close();
                    return user;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
        }

    }
}
