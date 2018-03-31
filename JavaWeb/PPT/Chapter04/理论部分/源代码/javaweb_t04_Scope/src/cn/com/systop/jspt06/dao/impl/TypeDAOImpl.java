package cn.com.systop.jspt06.dao.impl;

import java.util.ArrayList;
import java.util.List;

import cn.com.systop.jspt06.dao.TypeDAO;
import cn.com.systop.jspt06.entity.Type;

public class TypeDAOImpl extends BaseDAO implements TypeDAO {

	// ��Ӱ������ӷ���
	public int save(Type type) {
		int row = 0;
		String sql = "INSERT INTO type(typename) VALUES(?)";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			pstm.setString(1, type.getTypeName());// �������������ֵ
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��Ӱ������·���
	public int update(Type type) {
		int row = 0;
		String sql = "UPDATE type SET typeName = ? WHERE typeID = ?";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			// �������������ֵ
			pstm.setString(1, type.getTypeName());
			pstm.setInt(2, type.getTypeID());
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��Ӱ����ɾ������
	public int delete(int typeID) {
		int row = 0;
		String sql = "DELETE FROM type WHERE typeID = ?";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			pstm.setInt(1, typeID);// �������������ֵ
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��Ӱ�����б��ѯ����
	public List search() {
		List list = new ArrayList();
		String sql = "SELECT * FROM type";// SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			rs = pstm.executeQuery();// ִ��sql���,���ؽ������
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
		return list;// ���ص�Ӱ�����б�
	}
}
