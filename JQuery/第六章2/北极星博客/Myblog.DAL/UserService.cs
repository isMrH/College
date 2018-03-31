using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Myblog.Model;


namespace Myblog.DAL
{
   public  static class UserService
    {
       /// <summary>
       /// 添加用户
       /// </summary>
       /// <param name="user"></param>
        public static void AddUser(User user)
        {
            string sql =
                "INSERT Users (LoginId, LoginPwd, Name, QQ, Mail)" +
                "VALUES (@LoginId, @LoginPwd, @Name, @QQ, @Mail)";
            
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@LoginId", user.LoginId),
                    new SqlParameter("@LoginPwd", user.LoginPwd),
                    new SqlParameter("@Name", user.Name),
                    new SqlParameter("@QQ", user.QQ),
                    new SqlParameter("@Mail", user.Mail)
                };

            DBHelper.Execute (sql, para);           
        }

       /// <summary>
       /// 用户登录判断
       /// </summary>
       /// <param name="loginId"></param>
       /// <param name="pwd"></param>
       /// <returns></returns>
        public static int Login(string loginId,string pwd)
        {
            string sql = "SELECT * FROM Users WHERE LoginId = @LoginId and LoginPwd=@LoginPwd";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@LoginId", loginId),
                new SqlParameter ("@LoginPwd",pwd)
            };

            DataTable table = DBHelper.Search(sql, paras);
            return table.Rows.Count;
        }            
		
       /// <summary>
       /// 判断用户名是否重复注册
       /// </summary>
       /// <param name="loginId"></param>
       /// <returns></returns>
        public static User GetUserByLoginId(string loginId)
        {
            string sql = "SELECT * FROM Users WHERE LoginId = @loginId";

            SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@LoginId", loginId));
            if (reader.Read())
            {
                User user = new User();

                user.Id = (int)reader["Id"];
                user.LoginId = (string)reader["LoginId"];
                user.LoginPwd = (string)reader["LoginPwd"];
                user.Name = (string)reader["Name"];
                user.QQ = (string)reader["QQ"];
                user.Mail = (string)reader["Mail"];

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
