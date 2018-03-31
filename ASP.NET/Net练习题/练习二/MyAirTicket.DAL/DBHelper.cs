using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyAirTicket.DAL
{
    public class DBHelper
    {
        public static string constr = "server=.;database=MyAirTicket;uid=sa;pwd=sa";
        public static SqlConnection con = new SqlConnection(constr);

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
        public static DataTable GetTable(string strsql, params SqlParameter[] paras)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql, con);

            sda.SelectCommand.Parameters.AddRange(paras);
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

        public static object GetScalar(string strsql)
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
