package cn.com.systop.jspt04.dao.impl;

import java.util.ArrayList;
import java.util.List;

import cn.com.systop.jspt04.dao.TypeDAO;
import cn.com.systop.jspt04.entity.Type;

public class TypeDAOImpl extends BaseDAO {

	public int delete(int typeID) {
		// TODO Auto-generated method stub
		return 0;
	}

	public int save(Type type) {
		// TODO Auto-generated method stub
		return 0;
	}

	public List search() {
		List list = new ArrayList();
		String sql = "SELECT * FROM type";// SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			// ִ��sql���,���ؽ������
			rs = pstm.executeQuery();
			while (rs.next()) {
				// ���������������Ӱ��������װ����
				Type type = new Type();
				type.setTypeID(rs.getInt("typeID"));
				type.setTypeName(rs.getString("typeName"));
				// ����Ӱ���������ӵ�ArrayList������
				list.add(type);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return list;
	}

	public int update(Type type) {
		// TODO Auto-generated method stub
		return 0;
	}

}
