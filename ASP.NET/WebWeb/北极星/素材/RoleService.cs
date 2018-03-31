using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Data.SqlClient;
using System.Data;

namespace MySchool.DAL
{
    public static partial class RoleService
    {
        public static int AddRole(Role role)
        {
            string sql =
                "INSERT into Roles (RoleName, RoleDesc)  VALUES (@RoleName, @RoleDesc)";           

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@RoleName", role.RoleName),
					new SqlParameter("@RoleDesc", role.RoleDesc)
				};

                return DBHelper.ExecuteCommand (sql, para);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static int DeleteRole(Role role)
        {
           return  DeleteRoleByRoleId(role.RoleId);
        }

        public static int DeleteRoleByRoleId(int roleId)
        {
            string sql = "DELETE Roles WHERE RoleId = @RoleId";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@RoleId", roleId)
				};

                return  DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static int  ModifyRole(Role role)
        {
            string sql =
                "UPDATE Roles  SET  RoleName = @RoleName, RoleDesc = @RoleDesc WHERE RoleId = @RoleId";


            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@RoleId", role.RoleId),
					new SqlParameter("@RoleName", role.RoleName),
					new SqlParameter("@RoleDesc", role.RoleDesc)
				};

                return DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        public static List<Role> GetAllRoles()
        {
            string sqlAll = "SELECT * FROM Roles";
            return GetRolesBySql(sqlAll);
        }

        public static Role GetRoleByRoleId(int roleId)
        {
            string sql = "SELECT * FROM Roles WHERE RoleId = @RoleId";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@RoleId", roleId));
                if (reader.Read())
                {
                    Role role = new Role();

                    role.RoleId = (int)reader["RoleId"];
                    role.RoleName = (string)reader["RoleName"];
                    role.RoleDesc = (string)reader["RoleDesc"];

                    reader.Close();

                    return role;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }




        private static List<Role> GetRolesBySql(string safeSql)
        {
            List<Role> list = new List<Role>();

            try
            {
                DataTable table = DBHelper.GetDataTable (safeSql);

                foreach (DataRow row in table.Rows)
                {
                    Role role = new Role();

                    role.RoleId = (int)row["RoleId"];
                    role.RoleName = (string)row["RoleName"];
                    role.RoleDesc = (string)row["RoleDesc"];

                    list.Add(role);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        private static List<Role> GetRolesBySql(string sql, params SqlParameter[] values)
        {
            List<Role> list = new List<Role>();

            try
            {
                DataTable table = DBHelper.GetDataTable(sql, values);

                foreach (DataRow row in table.Rows)
                {
                    Role role = new Role();

                    role.RoleId = (int)row["RoleId"];
                    role.RoleName = (string)row["RoleName"];
                    role.RoleDesc = (string)row["RoleDesc"];

                    list.Add(role);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

    }
}
