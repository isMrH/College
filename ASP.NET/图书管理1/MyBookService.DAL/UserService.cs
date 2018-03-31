using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyBook.Model;

namespace MyBookService.DAL
{
    public class UserService
    {
        public static Users GetUsersByID(string LoginId)
        {


            string strsql = "select * from users where LoginId='" + LoginId+"'";
            return GetUsersBySql(strsql)[0];

        }

        private static List<Users> GetUsersBySql(string strsql)
        {
            List<Users> list = new List<Users>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                Users us = new Users();
                us.id = Convert.ToInt32(row["ID"]);
                us.username = row["LoginId"].ToString();
                us.userpassword = row["LoginPwd"].ToString();
                list.Add(us);
            }

            return list;
        }
    }
}
