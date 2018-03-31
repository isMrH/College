package com.test.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class BaseDao {

	private static final String DRIVER = "com.microsoft.sqlserver.jdbc.SQLServerDriver";// SQL Server 2005��JDBC������

	private static final String URL = "jdbc:sqlserver://localhost:1433;DatabaseName=TestMVC";// ���ڱ�ʶ���ݿ��URL

	private static final String UNAME = "sa";// ���ݿ��û���

	private static final String UPWD = "sa";// ���ݿ�����

	protected Connection con;// ���ݿ����Ӷ���

	protected PreparedStatement pstm;// Ԥ�����SQL������

	protected Statement stmt;// SQL������

	protected ResultSet rs;// ���������

	// ��ȡ���ݿ�����
	protected void getConnection() throws Exception {
		Class.forName(DRIVER);
		con = DriverManager.getConnection(URL, UNAME, UPWD);
	}

	// �ͷ����ݿ���Դ
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
