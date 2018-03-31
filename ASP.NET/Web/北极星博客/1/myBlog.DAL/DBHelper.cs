using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace myBlog.DAL
{
    class DBHelper
    {
        public static SqlConnection con = new SqlConnection("server=.;database=myblog;uid=sa;pwd=sa;");
        //执行增删改语句
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
        public static int ExecuteCommand(string strsql,params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);
            cmd.Parameters.AddRange(paras);
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
        ////执行select查找语句，（返回单行单列）
        public static object GetScaler(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open(); ;
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
        // 单参数的查询
        // paras  sql参数数组
        public static object GetScaler(string strsql, params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);
            cmd.Parameters.AddRange(paras);  //传入参数数组
            try
            {
                con.Open(); ;
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
        

        public static DataTable GetTable(string strsql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql,con);
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
    }
    
}
