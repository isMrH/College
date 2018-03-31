package cn.com.ambow.movie.util;

import java.io.IOException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Properties;

public class DBUtil {

//	private String driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
//	private String url = "jdbc:sqlserver://localhost:1433;databasename=movie";
//	private String user = "sa";
//	private String pwd = "sa";

	private static final String DRIVER = "com.mysql.jdbc.Driver";
	private static final String URL = "jdbc:mysql://localhost:3306/movie";
	private static final String UNAME = "root";
	private static final String UPWD = "root";

	
	private Connection conn;

	public void openConnection() throws SQLException, ClassNotFoundException,
			IOException {
		if (conn == null) {
			Class.forName(DRIVER);
			conn = DriverManager.getConnection(URL, UNAME, UPWD);
		}
	}

	public void closeConnection() throws SQLException {
		if (conn != null && conn.isClosed() == false) {
			conn.close();
			conn = null;
		}
	}

	public void execUpdate(String sql, ArrayList params) throws SQLException {
		PreparedStatement pstmt = this.conn.prepareStatement(sql);
		if (params != null && params.size() > 0) {
			int index = 1;
			for (Object o : params) {
				pstmt.setObject(index, o);
				index++;
			}
		}
		pstmt.executeUpdate();
	}

	public ResultSet execQuery(String sql, ArrayList params)
			throws SQLException {
		PreparedStatement pstmt = this.conn.prepareStatement(sql);
		if (params != null && params.size() > 0) {
			int index = 1;
			for (Object o : params) {
				pstmt.setObject(index, o);
				index++;
			}
		}
		ResultSet rs = pstmt.executeQuery();
		return rs;
	}

}
