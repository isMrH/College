package cn.com.systop.jspt06.dao.impl;

import cn.com.systop.jspt06.dao.UsersDAO;
import cn.com.systop.jspt06.entity.Users;

public class UsersDAOImpl extends BaseDAO implements UsersDAO {

	// 用户注册
	public int save(Users users) {
		int row = 0;
		String sql = "INSERT INTO users(userName,userPass,userIDCode,userTel,userAddress,userZip) VALUES(?,?,?,?,?,?)";// 带输入参数的SQL语句
		// 创建String数组放置输入参数的值
		String[] param = { users.getUserName(), users.getUserPass(),
				users.getUserIDCode(), users.getUserTel(),
				users.getUserAddress(), users.getUserZip() };
		try {
			// 调用父类的executeSQL方法,返回受影响的行数。
			row = super.executeSQL(sql, param);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return row;
	}

	// 修改密码
	public int update(Users users) {
		int row = 0;
		String sql = "UPDATE users SET userPass = ? WHERE userID = ?";// 带输入参数的SQL语句
		// 创建String数组放置输入参数的值
		String[] param = { users.getUserPass(), users.getUserID() + "" };
		try {
			// 调用父类的executeSQL方法,返回受影响的行数。
			row = super.executeSQL(sql, param);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return row;
	}
	
	// 登录验证
	public Users doLogin(String userName, String passWord) {
		Users users = null;
		String sql = "SELECT * FROM users WHERE userName=? AND userPass=?";// SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			// 设置输入参数的值
			pstm.setString(1, userName);
			pstm.setString(2, passWord);
			rs = pstm.executeQuery();// 执行sql语句,返回结果集。
			if (rs.next()) {
				// 如果用户名和密码都正确遍历结果集创建用户对象封装数据
				users = new Users();
				users.setUserID(rs.getInt(1));
				users.setUserName(rs.getString(2));
				users.setUserPass(rs.getString(3));
				users.setUserIDCode(rs.getString(4));
				users.setUserTel(rs.getString(5));
				users.setUserAddress(rs.getString(6));
				users.setUserZip(rs.getString(7));
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return users;// 返回用户对象
	}
}
