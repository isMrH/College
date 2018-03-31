using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myBlog.Model;
using System.Data.SqlClient;

namespace myBlog.DAL
{
    public class UsersService
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
            object obj = DBHelper.GetScaler(strsql, paras);

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
        //public static int insertUser(Users user)
        //{
        //    string strsql = string.Format("insert into Users values(LoginId='{0}',LoginPwd='{1}',Name='{2}',QQ='{3}',Mail='{4}')", user.LoginId, user.LoginPwd, user.Name, user.Qq, user.Mail);
        //    return 
        //}
    }
}
