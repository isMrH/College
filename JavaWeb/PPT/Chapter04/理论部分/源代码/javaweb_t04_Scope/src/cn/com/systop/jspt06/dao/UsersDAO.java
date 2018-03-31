package cn.com.systop.jspt06.dao;

import cn.com.systop.jspt06.entity.Users;

public interface UsersDAO {

	// 用户注册
	public int save(Users users);

	// 修改密码
	public int update(Users users);

	// 登录验证
	public Users doLogin(String userName, String passWord);
}
