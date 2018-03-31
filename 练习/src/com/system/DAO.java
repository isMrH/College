package com.system;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DAO {

	//�������ݿ��url
	String url = "jdbc:sqlserver://localhost:1433;databaseName=Movie";
	//�������ݿ��û���
	String user = "sa";
	//�������ݿ�����
	String password = "sa";
	//�������Ӷ���
	Connection con = null;
	//����statement����
	Statement stmt = null;
	//���������
	ResultSet rs = null;
	//����Ԥ�������
	PreparedStatement pstm = null;


	public Connection getConn(){
		try {
			//��������
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			//����connection����
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
			//7���ر�stmt
			if(stmt != null){
				stmt.close();
			}
			//8���ر�con
			if(con != null){
				con.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		}
	

}
