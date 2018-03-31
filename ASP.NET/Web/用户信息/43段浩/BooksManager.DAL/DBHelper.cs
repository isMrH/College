using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BooksManager.DAL
{
    class DBHelper
    {
        public static string constr = "server=.;database=BooksManager;uid=sa;pwd=sa";//连接数据库的连接串
        public static SqlConnection con = new SqlConnection(constr);


        //insert update delete
        public static int ExecuteCommand(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                int cnt = cmd.ExecuteNonQuery();
                return cnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        // select * from tablename
        public static DataTable GetTable(string strsql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql, con);

            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 返回单行单列 select count(*) from tablename
        public static object GetScaler(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }
    
}
