package com.test.dao;

import com.test.model.UserInfo;

public class UserDao extends BaseDao {

	public UserInfo login(String username,String pwd){
		UserInfo user = null;
		//sql���
		String sql = "select * from T_User where username=? and userpwd=?";
		try {
			//�������ݿ�
			super.getConnection();
			//Ԥ����sql���
			pstm = con.prepareStatement(sql);
			//�滻ռλ��
			pstm.setString(1, username);
			pstm.setString(2, pwd);
			//ִ�����
			rs = pstm.executeQuery();
			//������
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
