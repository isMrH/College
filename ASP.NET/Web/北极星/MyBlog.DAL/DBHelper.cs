using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MyBlog.DAL
{
    public class DBHelper
    {
        private static string constr = "server=.\\sqlexpress;uid=sa;pwd=sa;database=myblog";
        //private static string constr = "server=.\\sqlexpress;integrated security=sspi;database=MySchool";

        // private static string constr = ConfigurationManager.ConnectionStrings["MobileConStr"].ConnectionString;
        private static SqlConnection con = new SqlConnection(constr);

        /// <summary>
        /// 执行添删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                return cmd.ExecuteNonQuery();

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

        /// <summary>
        /// 执行添删改操作（执行有参数的SQL语句）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] para)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                //将参数添加到参数集合中
                cmd.Parameters.AddRange(para);
                return cmd.ExecuteNonQuery();

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

        /// <summary>
        /// 返回DataReader的查询方法
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string safeSql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(safeSql, con);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 返回DataReader的查询方法(执行有参数的查询语句）
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string safeSql, params SqlParameter[] para)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(safeSql, con);
                cmd.Parameters.AddRange(para);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 返回DataTable的查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            try
            {
                con.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds);
                return ds.Tables[0];

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
        /// <summary>
        /// 返回DataTable的查询方法(执行有参数的查询语句）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params SqlParameter[] para)
        {
            try
            {
                con.Open();
                //SqlDataAdapter myAdapter = new SqlDataAdapter(sql, con);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(para);
                SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds);
                return ds.Tables[0];

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
        /// <summary>
        /// 返回单值的查询方法
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static object GetScalar(string safeSql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(safeSql, con);
                return cmd.ExecuteScalar();

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

        /// <summary>
        /// 返回单值的查询方法(有参数的查询语句）
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static object GetScalar(string safeSql, params SqlParameter[] para)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(safeSql, con);
                cmd.Parameters.AddRange(para);
                return cmd.ExecuteScalar();

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
