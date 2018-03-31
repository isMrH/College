using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
    public static partial class UserService
    {
        public static int AddUser(User user)
        {
            string sql =
                "INSERT into Users (UserName, RealName, PassWord, Phone, Email, RoleId)" +
                "VALUES (@UserName, @RealName, @PassWord, @Phone, @Email, @RoleId)";       

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@RoleId", user.Role.RoleId), //FK
					new SqlParameter("@UserName", user.UserName),
					new SqlParameter("@RealName", user.RealName),
					new SqlParameter("@PassWord", user.PassWord),
					new SqlParameter("@Phone", user.Phone),
					new SqlParameter("@Email", user.Email)
				};

                return DBHelper.GetScalar(sql, para);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static int DeleteUser(User user)
        {
            return DeleteUserByUserId(user.UserId);
        }

        public static int  DeleteUserByUserId(int userId)
        {
            string sql = "DELETE Users WHERE UserId = @UserId";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserId", userId)
				};

                return  DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static int ModifyUser(User user)
        {
            string sql =
                "UPDATE Users SET RoleId = @RoleId,UserName = @UserName,RealName = @RealName,PassWord = @PassWord,Phone = @Phone,Email = @Email WHERE UserId = @UserId";              

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserId", user.UserId),
					new SqlParameter("@RoleId", user.Role.RoleId), //FK
					new SqlParameter("@UserName", user.UserName),
					new SqlParameter("@RealName", user.RealName),
					new SqlParameter("@PassWord", user.PassWord),
					new SqlParameter("@Phone", user.Phone),
					new SqlParameter("@Email", user.Email)
				};

                return DBHelper.ExecuteCommand(sql, para);
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
            return GetUsersBySql(sqlAll);
        }

        public static User GetUserByUserId(int userId)
        {
            string sql = "SELECT * FROM Users WHERE UserId = @UserId";

            int roleId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@UserId", userId));
                if (reader.Read())
                {
                    User user = new User();

                    user.UserId = (int)reader["UserId"];
                    user.UserName = (string)reader["UserName"];
                    user.RealName = (string)reader["RealName"];
                    user.PassWord = (string)reader["PassWord"];
                    user.Phone = (string)reader["Phone"];
                    user.Email = (string)reader["Email"];
                    roleId = (int)reader["RoleId"]; //FK

                    reader.Close();

                    user.Role = RoleService.GetRoleByRoleId(roleId);//外键对象变量赋值

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
                throw e;
            }
        }




        private static IList<User> GetUsersBySql(string safeSql)
        {
            List<User> list = new List<User>();

            try
            {
                DataTable table = DBHelper.GetDataTable (safeSql);

                foreach (DataRow row in table.Rows)
                {
                    User user = new User();

                    user.UserId = (int)row["UserId"];
                    user.UserName = (string)row["UserName"];
                    user.RealName = (string)row["RealName"];
                    user.PassWord = (string)row["PassWord"];
                    user.Phone = (string)row["Phone"];
                    user.Email = (string)row["Email"];
                    user.Role = RoleService.GetRoleByRoleId((int)row["RoleId"]); //FK

                    list.Add(user);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        private static IList<User> GetUsersBySql(string sql, params SqlParameter[] values)
        {
            List<User> list = new List<User>();

            try
            {
                DataTable table = DBHelper.GetDataTable (sql, values);

                foreach (DataRow row in table.Rows)
                {
                    User user = new User();

                    user.UserId = (int)row["UserId"];
                    user.UserName = (string)row["UserName"];
                    user.RealName = (string)row["RealName"];
                    user.PassWord = (string)row["PassWord"];
                    user.Phone = (string)row["Phone"];
                    user.Email = (string)row["Email"];
                    user.Role = RoleService.GetRoleByRoleId((int)row["RoleId"]); //FK

                    list.Add(user);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
        /// <summary>
        /// 根据用户名查找用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User GetUserByName(string username)
        {
            string sql = "SELECT * FROM Users WHERE UserName = @UserName";

            int roleId;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@UserName", username));
                if (reader.Read())
                {
                    User user = new User();

                    user.UserId = (int)reader["UserId"];
                    user.UserName = (string)reader["UserName"];
                    user.RealName = (string)reader["RealName"];
                    user.PassWord = (string)reader["PassWord"];
                    user.Phone = (string)reader["Phone"];
                    user.Email = (string)reader["Email"];
                    roleId = (int)reader["RoleId"]; //FK

                    reader.Close();

                    user.Role = RoleService.GetRoleByRoleId(roleId);

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
                throw e;
            }
        }

    }
}
