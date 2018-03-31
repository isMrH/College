/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package Exe;

import java.sql.Connection;
import java.sql.DriverManager;
/**
 *
 * @author Administrator
 */
public class Database {
        static String url="jdbc:sqlserver://localhost:1433;databaseName=Movie";
        static String user="sa";
        static String pwd="sa";
	static Connection con=null;
	public static Connection getcon()
	{
		try {
			//加载驱动
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			//创建connection对象
			con = DriverManager.getConnection(url, user, pwd);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return con;
	}
}
