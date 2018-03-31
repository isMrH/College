package cn.com.systop.jspt04.dao;

import java.util.List;

import cn.com.systop.jspt04.entity.Type;

public interface TypeDAO {

	// 添加电影分类
	public int save(Type type);

	// 修改电影分类
	public int update(Type type);

	// 删除电影分类
	public int delete(int typeID);

	// 查找电影分类
	public List search();
}
