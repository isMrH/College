package cn.com.systop.l07.javabean;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import cn.com.systop.l07.connection.DBConnection;

public class UserBean {
	private String userName; 
	private String userPassword;
	private String error; 
	public String getUserName() {
		return userName;
	}
	public void setUserName(String userName) {
		this.userName = userName;
	}
	public String getUserPassword() {
		return userPassword;
	}
	public void setUserPassword(String userPassword) {
		this.userPassword = userPassword;
	}
	public String getError() {
		return error;
	}
	public void setError(String error) {
		this.error = error;
	}
	public boolean login(){
		boolean flag = false;
		Connection con = DBConnection.getConnection();
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		String sql = "select * from users where username = ?";
		try {
			pstmt = con.prepareStatement(sql);
			pstmt.setString(1, this.getUserName());
			rs = pstmt.executeQuery();
			if(rs.next()){
				String password = rs.getString("userpass");
				if(this.getUserPassword().equals(password)){
					flag = true;
				}else{
					this.setError("error");
				}
			}else{
				this.setError("error");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			try {
				rs.close();
				pstmt.close();
				con.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		return flag;
	}
}
