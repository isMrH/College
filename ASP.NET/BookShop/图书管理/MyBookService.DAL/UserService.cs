using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class UserService
    {
        //查询账户和密码是否输入正确
        public int LoginUser(string LoginId, string LoginPwd)
        {
            string strsql = "select count(*) from Users where LoginId=@LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@LoginId",LoginId),
                new SqlParameter("@LoginPwd",LoginPwd),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql,paras));
        }

        //查重
        public int IsHasInfo(string LoginId)
        {
            string strsql = "select count(*) from Users where LoginId=@LoginId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@LoginId",LoginId),
            };
            return Convert.ToInt32(DBHelper.GetScalar(strsql, paras));
        }
        //添加用户
        public int AddInfo(User user)
        {
            string strsql = "insert into Users(LoginID,LoginPwd) values(@loginid,@loginpwd)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@loginid",user.LoginId),
                new SqlParameter("@loginpwd",user.LoginPwd),
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //获得在线用户
        public List<User> GetOnLine()
        {
            string strsql = "select * from Users where UserStateId=1 and IsOnLine=1";
            return GetInfoBySql(strsql);
        }
        
        //定义私有方法
        private List<User> GetInfoBySql(string strsql)
        {
            List<User> list = new List<User>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                User user = new User();
                user.Address = row["Address"].ToString();
                user.LoginId = row["LoginId"].ToString();
                user.Id = Convert.ToInt32( row["Id"]);
                user.LoginPwd = row["LoginPwd"].ToString();
                user.Mail = row["Mail"].ToString();
                user.Name = row["Name"].ToString();
                user.Phone = row["Phone"].ToString();
                list.Add(user);
            }

            return list;
        }
    }
}
