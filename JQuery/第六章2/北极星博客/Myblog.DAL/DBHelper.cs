using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Myblog.DAL
{
    /// <summary>
    /// DataAccess 的摘要说明
    /// </summary>
    public class DBHelper
    {

        private static string constr = "server=.;uid=sa;pwd=sa;database=MyBlog";
       // private static string constr = "server=.\\sql2005;integrated security=sspi;database=MyBlog";
        private static SqlConnection con = new SqlConnection(constr);

        //执行添删改操作
        public static void Execute(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

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
        //执行添删改操作
        public static void Execute(string sql, SqlParameter[] paras)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();

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
        //执行查询语句
        public static DataTable Search(string sql)
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


        //执行查询语句
        public static DataTable Search(string sql, SqlParameter[] para)
        {
            try
            {
                con.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, con);
                myAdapter.SelectCommand.Parameters.AddRange(para);
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
        /// 返回SqlDataReader的有参的查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(values);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

