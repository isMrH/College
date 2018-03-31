package com.systop.javabean;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.systop.sql.*;

public class UserBean {
	private String userName;	//用户名
	private String userPassword;	//密码
	private String error;	//错误信息
	public String getuserName() {
		return userName;
	}
	public void userName(String userName) {
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
	
	//login 方法
	public boolean login(){
		boolean flag=false;
		Connection con=DBCon.getCon();
		PreparedStatement pstmt=null;
		ResultSet rs=null;
		String sql="select * from Users where username=?";
		try{
			pstmt=con.prepareStatement(sql);
			pstmt.setString(1, this.getuserName());
			rs = pstmt.executeQuery();
			if(rs.next()){
				String password=rs.getString("userpassword");
				if(this.getUserPassword().equals(password)){
					flag=true;
				}else{
					this.setError("error");
				}	
			}else{
					this.setError("error");
			}			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			try{
				rs.close();
				pstmt.close();
				con.close();
			}catch(SQLException e){
				e.printStackTrace();
			}
		}
		return flag;
		
	}
	
}
