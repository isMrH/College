package cn.com.systop.jspt06.dao;

import java.util.List;

import cn.com.systop.jspt06.entity.Movies;

public interface MoviesDAO {

	// ��ӰDVD��ӷ���
	public int save(Movies movies);

	// ��ӰDVD���·���
	public int update(Movies movies);

	// ��ӰDVDɾ������
	public int delete(int movieID);

	// ��ӰDVD��ѯ����
	public List search(int pageNo, int typeID);
}
