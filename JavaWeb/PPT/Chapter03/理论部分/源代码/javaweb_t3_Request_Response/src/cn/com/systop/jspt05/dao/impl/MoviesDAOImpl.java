package cn.com.systop.jspt05.dao.impl;

import java.util.ArrayList;
import java.util.List;

import cn.com.systop.jspt05.dao.MoviesDAO;
import cn.com.systop.jspt05.entity.Movies;

public class MoviesDAOImpl extends BaseDAO implements MoviesDAO {

	// 电影DVD添加方法
	public int save(Movies movies) {
		int row = 0;
		String sql = "INSERT INTO movies(moviename,director,typeid,stardom,region,showtime,description,image,price) VALUES(?,?,?,?,?,?,?,?,?)";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			// 设置输入参数的值
			pstm.setString(1, movies.getMovieName());
			pstm.setString(2, movies.getDirector());
			pstm.setInt(3, movies.getTypeID());
			pstm.setString(4, movies.getStardom());
			pstm.setString(5, movies.getRegion());
			pstm.setString(6, movies.getShowtime());
			pstm.setString(7, movies.getDescription());
			pstm.setString(8, movies.getImage());
			pstm.setDouble(9, movies.getPrice());
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影DVD更新方法
	public int update(Movies movies) {
		int row = 0;
		String sql = "UPDATE movies SET movieName = ? WHERE movieID = ?";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			// 设置输入参数的值
			pstm.setString(1, movies.getMovieName());
			pstm.setInt(2, movies.getMovieID());
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影DVD删除方法
	public int delete(int movieID) {
		int row = 0;
		String sql = "DELETE FROM movies WHERE movieID = ?";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			pstm.setInt(1, movieID);// 设置输入参数的值
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影DVD查询方法
	public List search(int pageNo, int typeID) {
		List list = new ArrayList();// 用来保存电影DVD列表
		int pageSize = 10;// 每页最大记录数
		int rows = 0;// 表示每页之前的记录数
		if (pageNo > 1) {
			// 计算每页之前记录数，例如第2页之前记录数为（2-1）*10=10条
			rows = (pageNo - 1) * pageSize;
		}
		/*String sql = "SELECT top " + pageSize + " * FROM movies WHERE typeID="
				+ typeID + " AND movieID not in(select top " + rows
				+ " movieID from " + "movies where typeID=" + typeID
				+ " order by movieID) ORDER BY movieID";// SQL语句
		*/
		String sql="select * from movies where typeid="+typeID+" limit "+rows+","+pageSize;
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			rs = pstm.executeQuery();// 执行sql语句,返回结果集
			while (rs.next()) {
				// 遍历结果集创建电影DVD对象封装数据
				Movies movies = new Movies();
				movies.setMovieID(rs.getInt("movieID"));
				movies.setMovieName(rs.getString("movieName"));
				movies.setDirector(rs.getString("director"));
				movies.setTypeID(rs.getInt("typeID"));
				movies.setStardom(rs.getString("stardom"));
				movies.setRegion(rs.getString("region"));
				movies.setShowtime(rs.getString("showtime"));
				movies.setImage(rs.getString("image"));
				movies.setDescription(rs.getString("description"));
				movies.setPrice(rs.getDouble("price"));
				// 将电影DVD对象添加到ArrayList集合中
				list.add(movies);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return list;
	}
}
