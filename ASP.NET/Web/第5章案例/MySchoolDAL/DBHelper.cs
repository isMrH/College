using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
    public static class DBHelper
    {
        private static SqlConnection connection;
        /// <summary>
        /// 连库属性
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                //string connectionString = "server=.\\SQL2005;database=MySchool;uid=sa;pwd=sa";               
                string connectionString = "server=.\\SQLEXPRESS;database=MySchool;uid=sa;pwd=sa";
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        /// <summary>
        /// 执行单向语句（添加，删除，修改）的方法
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string safeSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }


        }
        /// <summary>
        /// 有参数的单向语句方法（添加，删除，修改）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// 返回单值的查询方法
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static int GetScalar(string safeSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// 返回单值的有参的查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetScalar(string sql, params SqlParameter[] values)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// 调用存储过程的方法
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetScalar(params SqlParameter[] values)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Pro_InsertOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(values);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
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
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
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
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
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
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string safeSql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// 返回DataTable的有参的查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params SqlParameter[] values)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
