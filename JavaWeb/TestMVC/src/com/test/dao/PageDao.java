package com.test.dao;

import java.util.ArrayList;
import java.util.List;

import com.test.model.Message;

public class PageDao extends BaseDao {

	/**
	 * ��ѯ�������ݣ�����ҳ
	 * @return
	 */
	public List findAll(){
		//���巵�ؽṹ����
		List list = new ArrayList();
		
		//����sql���
		String sql = "select * from T_Message";
		try {
			//�������ݿ�
			super.getConnection();
			//Ԥ�������
			pstm = con.prepareStatement(sql);
			//ִ�����
			rs = pstm.executeQuery();
			//������
			while(rs.next()){
				//�����ݿ��ÿ���ֶζ�����һ������������
				Message message = new Message();
				message.setId(rs.getInt("id"));
				message.setTitle(rs.getString("title"));
				message.setMessage(rs.getString("message"));
				//��ÿ�����󶼴��뼯��
				list.add(message);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//�ر���������
			super.closeAll();
		}
		//�������յļ���
		return list;
	}
	
	/**
	 * ��ȡ�������
	 * @return
	 */
	public int maxSize(){
		int num = 0;
		//����sql���
		String sql = "select count(*) from T_Message";
		try {
			//�������ݿ�
			super.getConnection();
			//Ԥ�������
			pstm = con.prepareStatement(sql);
			//ִ�����
			rs = pstm.executeQuery();
			//������
			if(rs.next()){
				num = rs.getInt(1);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//�ر���������
			super.closeAll();
		}
		//�������յ�����
		return num;
	}
	
	
	public List findPage(int pageNo,int pageSize){
		//���巵�ؽṹ����
		List list = new ArrayList();
		
		//����sql���
		String sql = "select top "+pageSize+" * from T_Message " +
				"where id not in (select top "+(pageSize*(pageNo-1))+" id from T_Message order by id) order by id";
		try {
			//�������ݿ�
			super.getConnection();
			//Ԥ�������
			pstm = con.prepareStatement(sql);
			
			//ִ�����
			rs = pstm.executeQuery();
			//������
			while(rs.next()){
				//�����ݿ��ÿ���ֶζ�����һ������������
				Message message = new Message();
				message.setId(rs.getInt("id"));
				message.setTitle(rs.getString("title"));
				message.setMessage(rs.getString("message"));
				//��ÿ�����󶼴��뼯��
				list.add(message);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//�ر���������
			super.closeAll();
		}
		//�������յļ���
		return list;
	}
}
