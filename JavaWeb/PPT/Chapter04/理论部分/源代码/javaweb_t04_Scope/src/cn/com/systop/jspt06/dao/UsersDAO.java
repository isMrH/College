package cn.com.systop.jspt06.dao;

import cn.com.systop.jspt06.entity.Users;

public interface UsersDAO {

	// �û�ע��
	public int save(Users users);

	// �޸�����
	public int update(Users users);

	// ��¼��֤
	public Users doLogin(String userName, String passWord);
}
