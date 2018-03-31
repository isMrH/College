package com.systop.l07.connection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class DBConnection {

//	private final static String URL="jdbc:sqlserver://localhost:1433;databasename=movie";
//	private final static String USERNAME = "sa";
//	private final static String PASSWORD = "sa";
//	private final static String Driver="com.microsoft.sqlserver.jdbc.SQLServerDriver";

	private final static String URL="jdbc:mysql://localhost:3306/movie";
	private final static String USERNAME = "root";
	private final static String PASSWORD = "root";
	private final static String Driver="com.mysql.jdbc.Driver";
	
	public static Connection getConnection(){
		Connection con = null;
		try {
			Class.forName(Driver);
			con = DriverManager.getConnection(URL, USERNAME, PASSWORD);
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return con;
	}

}
