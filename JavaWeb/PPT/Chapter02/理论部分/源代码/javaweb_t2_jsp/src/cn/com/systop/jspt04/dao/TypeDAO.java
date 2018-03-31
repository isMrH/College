package cn.com.systop.jspt04.dao;

import java.util.List;

import cn.com.systop.jspt04.entity.Type;

public interface TypeDAO {

	// ��ӵ�Ӱ����
	public int save(Type type);

	// �޸ĵ�Ӱ����
	public int update(Type type);

	// ɾ����Ӱ����
	public int delete(int typeID);

	// ���ҵ�Ӱ����
	public List search();
}
