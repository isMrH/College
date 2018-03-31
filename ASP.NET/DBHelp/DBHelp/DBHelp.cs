
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DBHelp
{
    class DBHelp
    {
        static SqlConnection con = new SqlConnection("server=.\\sqlexpress;database=Students;uid=sa;pwd=sa");
        public static int ExecuteCommand(string strsql)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static DataTable GetTable(string strsql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql, con);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds, "aa");
                return ds.Tables["aa"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static object GetScaler(string strsql)
        {
            object obj;
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return obj;
        }
    }
}
