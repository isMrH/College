package com.system;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DAO {

	//连接数据库的url
	String url = "jdbc:sqlserver://localhost:1433;databaseName=Movie";
	//连接数据库用户名
	String user = "sa";
	//连接数据库密码
	String password = "sa";
	//定义连接对象
	Connection con = null;
	//定义statement对象
	Statement stmt = null;
	//结果集对象
	ResultSet rs = null;
	//创建预处理对象
	PreparedStatement pstm = null;


	public Connection getConn(){
		try {
			//加载驱动
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			//创建connection对象
			con = DriverManager.getConnection(url, user, password);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return con;
	}
	public void closeAll(){
		try {
			if(rs != null){
				rs.close();
			}
			//7、关闭stmt
			if(stmt != null){
				stmt.close();
			}
			//8、关闭con
			if(con != null){
				con.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		}
	

}
