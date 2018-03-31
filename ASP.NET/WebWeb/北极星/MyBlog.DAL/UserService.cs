using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlog.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBlog.DAL
{
    public class UserService
    {
        public static bool IsRegisteUser(string name, string pwd)
        {
            //使用参数来组织sql语句
            string strsql = "select count(*) from  users where loginid=@name and loginpwd=@pwd";

            //创建参数数组          
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@name",name),
                new SqlParameter("@pwd",pwd)
            };
            object obj = DBHelper.GetScalar(strsql, paras);

            int cnt = Convert.ToInt32(obj);
            if (cnt > 0)
            {
                return true;  //是注册用户
            }
            else
            {
                return false; //用户名或密码错误
            }

        }
        public static int insertUser(User user)
        {
            string strsql = "insert into Users values(@LoginId,@LoginPwd,@Name,@QQ,@Mail)";
            //创建参数数组          
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@LoginId",user.LoginId),
                new SqlParameter("@LoginPwd",user.LoginPwd),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@QQ",user.QQ),
                new SqlParameter("@Mail",user.Mail),
            };
            return DBHelper.ExecuteCommand(strsql, paras);


        }
        public static bool GetUsersName(string name)
        {
            string strsql = "select count(*) from  users where loginid=@name";

            //创建参数数组          
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@name",name),
            };
            object obj = DBHelper.GetScalar(strsql, paras);

            int cnt = Convert.ToInt32(obj);
            if (cnt > 0)
            {
                return true;  //是注册用户
            }
            else
            {
                return false; //用户名或密码错误
            }


        }
    

    }
}
