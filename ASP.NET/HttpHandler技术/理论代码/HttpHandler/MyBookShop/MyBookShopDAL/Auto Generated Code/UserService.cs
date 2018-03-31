//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:19
//============================================================

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
        public static User AddUser(User user)
		{
            string sql =
				"INSERT Users (LoginId, LoginPwd, Name, Address, Phone, Mail, UserRoleId, UserStateId)" +
				"VALUES (@LoginId, @LoginPwd, @Name, @Address, @Phone, @Mail, @UserRoleId, @UserStateId)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserStateId", user.UserState.Id), //FK
					new SqlParameter("@UserRoleId", user.UserRole.Id), //FK
					new SqlParameter("@LoginId", user.LoginId),
					new SqlParameter("@LoginPwd", user.LoginPwd),
					new SqlParameter("@Name", user.Name),
					new SqlParameter("@Address", user.Address),
					new SqlParameter("@Phone", user.Phone),
					new SqlParameter("@Mail", user.Mail)
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetUserById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                return null;
            }
		}
		
        public static void DeleteUser(User user)
		{
			DeleteUserById( user.Id );
		}

        public static void DeleteUserById(int id)
		{
            string sql = "DELETE Users WHERE Id = @Id";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void DeleteUserByLoginId(string loginId)
		{
            string sql = "DELETE Users WHERE LoginId = @LoginId";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@LoginId", loginId)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void DeleteUserByMail(string mail)
		{
            string sql = "DELETE Users WHERE Mail = @Mail";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Mail", mail)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyUser(User user)
        {
            string sql =
                "UPDATE Users " +
                "SET " +
	                "UserStateId = @UserStateId, " + //FK
	                "UserRoleId = @UserRoleId, " + //FK
	                "LoginId = @LoginId, " +
	                "LoginPwd = @LoginPwd, " +
	                "Name = @Name, " +
	                "Address = @Address, " +
	                "Phone = @Phone, " +
	                "Mail = @Mail " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", user.Id),
					new SqlParameter("@UserStateId", user.UserState.Id), //FK
					new SqlParameter("@UserRoleId", user.UserRole.Id), //FK
					new SqlParameter("@LoginId", user.LoginId),
					new SqlParameter("@LoginPwd", user.LoginPwd),
					new SqlParameter("@Name", user.Name),
					new SqlParameter("@Address", user.Address),
					new SqlParameter("@Phone", user.Phone),
					new SqlParameter("@Mail", user.Mail)
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<User> GetAllUsers()
        {
            string sqlAll = "SELECT * FROM Users";
			return GetUsersBySql( sqlAll );
        }
		
        public static User GetUserById(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id = @Id";

			int userStateId;
			int userRoleId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
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
					userStateId = (int)reader["UserStateId"]; //FK
					userRoleId = (int)reader["UserRoleId"]; //FK

                    reader.Close();

					user.UserState = UserStateService.GetUserStateById(userStateId);
					user.UserRole = UserRoleService.GetUserRoleById(userRoleId);
					
                    return user;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
		
        public static User GetUserByLoginId(string loginId)
        {
            string sql = "SELECT * FROM Users WHERE LoginId = @LoginId";

			int userStateId;
			int userRoleId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@LoginId", loginId));
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
					userStateId = (int)reader["UserStateId"]; //FK
					userRoleId = (int)reader["UserRoleId"]; //FK

                    reader.Close();
		
					user.UserState = UserStateService.GetUserStateById(userStateId);
					user.UserRole = UserRoleService.GetUserRoleById(userRoleId);

                    return user;
                }
                else
                {
					reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
		
        public static User GetUserByMail(string mail)
        {
            string sql = "SELECT * FROM Users WHERE Mail = @Mail";

			int userStateId;
			int userRoleId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Mail", mail));
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
					userStateId = (int)reader["UserStateId"]; //FK
					userRoleId = (int)reader["UserRoleId"]; //FK

                    reader.Close();
		
					user.UserState = UserStateService.GetUserStateById(userStateId);
					user.UserRole = UserRoleService.GetUserRoleById(userRoleId);

                    return user;
                }
                else
                {
					reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
		
		
		
		
        private static IList<User> GetUsersBySql( string safeSql )
        {
            List<User> list = new List<User>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					User user = new User();
					
					user.Id = (int)row["Id"];
					user.LoginId = (string)row["LoginId"];
					user.LoginPwd = (string)row["LoginPwd"];
					user.Name = (string)row["Name"];
					user.Address = (string)row["Address"];
					user.Phone = (string)row["Phone"];
					user.Mail = (string)row["Mail"];
					user.UserState = UserStateService.GetUserStateById((int)row["UserStateId"]); //FK
					user.UserRole = UserRoleService.GetUserRoleById((int)row["UserRoleId"]); //FK
	
					list.Add(user);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
		
        private static IList<User> GetUsersBySql( string sql, params SqlParameter[] values )
        {
            List<User> list = new List<User>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					User user = new User();
					
					user.Id = (int)row["Id"];
					user.LoginId = (string)row["LoginId"];
					user.LoginPwd = (string)row["LoginPwd"];
					user.Name = (string)row["Name"];
					user.Address = (string)row["Address"];
					user.Phone = (string)row["Phone"];
					user.Mail = (string)row["Mail"];
					user.UserState = UserStateService.GetUserStateById((int)row["UserStateId"]); //FK
					user.UserRole = UserRoleService.GetUserRoleById((int)row["UserRoleId"]); //FK
	
					list.Add(user);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
			
        }
		
	}
}
