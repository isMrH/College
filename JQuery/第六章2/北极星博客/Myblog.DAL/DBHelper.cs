using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Myblog.DAL
{
    /// <summary>
    /// DataAccess ��ժҪ˵��
    /// </summary>
    public class DBHelper
    {

        private static string constr = "server=.;uid=sa;pwd=sa;database=MyBlog";
       // private static string constr = "server=.\\sql2005;integrated security=sspi;database=MyBlog";
        private static SqlConnection con = new SqlConnection(constr);

        //ִ����ɾ�Ĳ���
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
        //ִ����ɾ�Ĳ���
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
        //ִ�в�ѯ���
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


        //ִ�в�ѯ���
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
        /// ����DataReader�Ĳ�ѯ����
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
        /// ����SqlDataReader���вεĲ�ѯ����
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

