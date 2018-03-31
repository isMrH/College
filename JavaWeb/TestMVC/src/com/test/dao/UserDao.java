package com.test.dao;

import com.test.model.UserInfo;

public class UserDao extends BaseDao {

	public UserInfo login(String username,String pwd){
		UserInfo user = null;
		//sql语句
		String sql = "select * from T_User where username=? and userpwd=?";
		try {
			//连接数据库
			super.getConnection();
			//预处理sql语句
			pstm = con.prepareStatement(sql);
			//替换占位符
			pstm.setString(1, username);
			pstm.setString(2, pwd);
			//执行语句
			rs = pstm.executeQuery();
			//处理结果
			if(rs.next()){
				user = new UserInfo();
				user.setId(rs.getInt(1));
				user.setUsername(rs.getString(2));
				user.setUserpwd(rs.getString(3));
			}
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			super.closeAll();
		}
		return user;
	}
}
