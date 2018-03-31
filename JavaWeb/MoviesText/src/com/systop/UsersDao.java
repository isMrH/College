package com.systop;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;



public class UsersDao{
	 //定义连接对象
    Connection con = null;
    //定义statement对象
    Statement stmt = null;
    //定义PreparedStatement对象
    PreparedStatement pstmt = null;
    //结果集对象
    ResultSet rs = null;
    /**
     *  添加电影
     */
	public Users doLogin(String userName, String passWord){
		Users users=null;
		String sql="select * from users where userName=? and userPass=?";	//sql语句
		try {
			con=DBConn.getCon();
			pstmt=con.prepareStatement(sql);
			pstmt.setString(1, userName);
			pstmt.setString(2, passWord);
			rs=pstmt.executeQuery();
			if(rs.next()){
				users=new Users();
				users.setUserID(rs.getInt(1));
				users.setUserName(rs.getString(2));
				users.setUserPass(rs.getString(3));				
			}
		}catch (Exception e) {
				// TODO: handle exception
				e.printStackTrace();
		}finally{
			try{
                rs.close();
                pstmt.close();
                con.close();
            }
            catch(Exception ex){
                ex.printStackTrace();
            }
		}
		return users;
	}
    
}
