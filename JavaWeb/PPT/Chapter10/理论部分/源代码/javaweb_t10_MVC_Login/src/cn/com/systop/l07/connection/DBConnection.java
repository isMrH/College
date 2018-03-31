package cn.com.systop.l07.connection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class DBConnection {

/*	
  	private final static String DRIVER="com.microsoft.sqlserver.jdbc.SQLServerDriver";
  	
  	private final static String URL="jdbc:sqlserver://localhost:1433;databasename=movie";

	private final static String USERNAME = "sa";

	private final static String PASSWORD = "sa";
*/
	private static final String DRIVER = "com.mysql.jdbc.Driver";

	private static final String URL = "jdbc:mysql://localhost:3306/movie";

	private static final String UNAME = "root";

	private static final String UPWD = "root";

	
	public static Connection getConnection(){
		Connection con = null;
		try {

			Class.forName(DRIVER);

			con = DriverManager.getConnection(URL, UNAME, UPWD);
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return con;
	}

}
