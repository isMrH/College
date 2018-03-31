package cn.com.systop.jspt06.dao;

import java.util.List;

import cn.com.systop.jspt06.entity.Movies;

public interface MoviesDAO {

	// 电影DVD添加方法
	public int save(Movies movies);

	// 电影DVD更新方法
	public int update(Movies movies);

	// 电影DVD删除方法
	public int delete(int movieID);

	// 电影DVD查询方法
	public List search(int pageNo, int typeID);
}
