package cn.com.systop.jspt06.dao.impl;

import java.util.ArrayList;
import java.util.List;

import cn.com.systop.jspt06.dao.TypeDAO;
import cn.com.systop.jspt06.entity.Type;

public class TypeDAOImpl extends BaseDAO implements TypeDAO {

	// 电影分类添加方法
	public int save(Type type) {
		int row = 0;
		String sql = "INSERT INTO type(typename) VALUES(?)";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			pstm.setString(1, type.getTypeName());// 设置输入参数的值
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影分类更新方法
	public int update(Type type) {
		int row = 0;
		String sql = "UPDATE type SET typeName = ? WHERE typeID = ?";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			// 设置输入参数的值
			pstm.setString(1, type.getTypeName());
			pstm.setInt(2, type.getTypeID());
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影分类删除方法
	public int delete(int typeID) {
		int row = 0;
		String sql = "DELETE FROM type WHERE typeID = ?";// 带输入参数的SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			pstm.setInt(1, typeID);// 设置输入参数的值
			row = pstm.executeUpdate();// 执行SQL语句,返回受影响的行数
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return row;// 返回受影响的行数
	}

	// 电影分类列表查询方法
	public List search() {
		List list = new ArrayList();
		String sql = "SELECT * FROM type";// SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			rs = pstm.executeQuery();// 执行sql语句,返回结果集。
			while (rs.next()) {
				// 遍历结果集创建电影分类对象封装数据
				Type type = new Type();
				type.setTypeID(rs.getInt("typeID"));
				type.setTypeName(rs.getString("typeName"));
				// 将电影分类对象添加到ArrayList集合中
				list.add(type);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// 释放数据库资源
		}
		return list;// 返回电影分类列表
	}
}
