using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MySchool.DAL
{
    public class DBHelper
    {
        private static SqlConnection con = new SqlConnection("server=.\\sqlexpress;database=myschool;uid=sa;pwd=sa");//连接数据库的连接串
        //insert updata delect  插入 更改 删除操作
        public static int ExecuteCommand(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);//创建命令对象
            try
            {
                con.Open();
                int cnt = cmd.ExecuteNonQuery();//执行SQL语句
                return cnt;//返回影响结果的记录条数
            }
            catch (Exception ex)
            {
                throw ex;//抛出异常
            }
            finally
            {
                con.Close();//关闭连接
            }
        }
        /// <summary>
        ///  SqlCommand方法的重写
        /// </summary>
        /// <param name="strsql"> sql语句</param>
        /// <param name="paras">数组名称</param>
        /// <returns></returns>
        public static int ExecuteCommand(string strsql, params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);//创建命令对象
            cmd.Parameters.AddRange(paras);//传入参数数组
            try
            {
                con.Open();
                int cnt = cmd.ExecuteNonQuery();//执行SQL语句
                return cnt;//返回影响结果的记录条数
            }
            catch (Exception ex)
            {
                throw ex;//抛出异常
            }
            finally
            {
                con.Close();//关闭连接
            }
        }
        //select count(*) from table 查询功能返回影响结果的记录条数返回单行单列
        public static object GetScaler(string strsql)
        {
            SqlCommand cmd = new SqlCommand(strsql, con);//创建操作对象
            try
            {
                con.Open();//打开连接
                object obj = cmd.ExecuteScalar();//执行查询操作
                return obj;
            }
            catch (Exception ex)//抛出异常
            {
                throw ex;
            }
            finally
            {
                con.Close();//关闭连接
            }

        }

        /// <summary>
        /// GetScaler方法的重载
        /// </summary>
        /// <param name="strsql">sql语句</param>
        /// <param name="paras">数组名称</param>
        /// <returns></returns>
        public static object GetScaler(string strsql, params SqlParameter[] paras)//GetScaler方法的重载
        {
            SqlCommand cmd = new SqlCommand(strsql, con);//创建操作对象
            cmd.Parameters.AddRange(paras);//传入参数数组
            try
            {
                con.Open();//打开连接
                object obj = cmd.ExecuteScalar();//执行查询操作
                return obj;
            }
            catch (Exception ex)//抛出异常
            {
                throw ex;
            }
            finally
            {
                con.Close();//关闭连接
            }

        }
        //select * from tablename查询功能返回数据集
        public static DataTable GetTable(string strsql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql, con);//适配器
            DataSet ds = new DataSet();//数据集对象
            try
            {
                sda.Fill(ds);//适配器对象填充
                return ds.Tables[0];//返回数据集中的数据
            }
            catch (Exception ex)//抛出异常
            {
                throw ex;
            }

        }
        /// <summary>
        /// GetTable方法的重写
        /// </summary>
        /// <param name="strsql"> sql语句</param>
        /// <param name="paras">数组</param>
        /// <returns></returns>
        public static DataTable GetTable(string strsql, params SqlParameter[] paras)
        {
            SqlDataAdapter sda = new SqlDataAdapter(strsql, con);//适配器
            sda.SelectCommand.Parameters.AddRange(paras);
            DataSet ds = new DataSet();//数据集对象
            try
            {
                sda.Fill(ds);//适配器对象填充
                return ds.Tables[0];//返回数据集中的数据
            }
            catch (Exception ex)//抛出异常
            {
                throw ex;
            }

        }
    }
}
