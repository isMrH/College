package com.test.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class BaseDao {

	private static final String DRIVER = "com.microsoft.sqlserver.jdbc.SQLServerDriver";// SQL Server 2005的JDBC驱动类

	private static final String URL = "jdbc:sqlserver://localhost:1433;DatabaseName=TestMVC";// 用于标识数据库的URL

	private static final String UNAME = "sa";// 数据库用户名

	private static final String UPWD = "sa";// 数据库密码

	protected Connection con;// 数据库连接对象

	protected PreparedStatement pstm;// 预编译的SQL语句对象

	protected Statement stmt;// SQL语句对象

	protected ResultSet rs;// 结果集对象

	// 获取数据库连接
	protected void getConnection() throws Exception {
		Class.forName(DRIVER);
		con = DriverManager.getConnection(URL, UNAME, UPWD);
	}

	// 释放数据库资源
	protected void closeAll() {
		if (rs != null) {
			try {
				rs.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		if (pstm != null) {
			try {
				pstm.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		if (stmt != null) {
			try {
				stmt.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		try {
			if (con != null && con.isClosed() == false) {
				con.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}
