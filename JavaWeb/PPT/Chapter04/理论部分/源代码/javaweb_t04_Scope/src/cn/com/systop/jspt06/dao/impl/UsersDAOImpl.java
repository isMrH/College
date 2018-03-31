package cn.com.systop.jspt06.dao.impl;

import cn.com.systop.jspt06.dao.UsersDAO;
import cn.com.systop.jspt06.entity.Users;

public class UsersDAOImpl extends BaseDAO implements UsersDAO {

	// �û�ע��
	public int save(Users users) {
		int row = 0;
		String sql = "INSERT INTO users(userName,userPass,userIDCode,userTel,userAddress,userZip) VALUES(?,?,?,?,?,?)";// �����������SQL���
		// ����String����������������ֵ
		String[] param = { users.getUserName(), users.getUserPass(),
				users.getUserIDCode(), users.getUserTel(),
				users.getUserAddress(), users.getUserZip() };
		try {
			// ���ø����executeSQL����,������Ӱ���������
			row = super.executeSQL(sql, param);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return row;
	}

	// �޸�����
	public int update(Users users) {
		int row = 0;
		String sql = "UPDATE users SET userPass = ? WHERE userID = ?";// �����������SQL���
		// ����String����������������ֵ
		String[] param = { users.getUserPass(), users.getUserID() + "" };
		try {
			// ���ø����executeSQL����,������Ӱ���������
			row = super.executeSQL(sql, param);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return row;
	}
	
	// ��¼��֤
	public Users doLogin(String userName, String passWord) {
		Users users = null;
		String sql = "SELECT * FROM users WHERE userName=? AND userPass=?";// SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			// �������������ֵ
			pstm.setString(1, userName);
			pstm.setString(2, passWord);
			rs = pstm.executeQuery();// ִ��sql���,���ؽ������
			if (rs.next()) {
				// ����û��������붼��ȷ��������������û������װ����
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
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return users;// �����û�����
	}
}
