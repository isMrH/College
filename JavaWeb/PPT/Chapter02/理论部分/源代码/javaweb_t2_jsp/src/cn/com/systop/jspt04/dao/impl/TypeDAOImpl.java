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
		String sql = "SELECT * FROM type";// SQL语句
		try {
			super.getConnection();// 调用父类方法获取数据库连接
			pstm = con.prepareStatement(sql);// 创建预编译的SQL语句对象
			// 执行sql语句,返回结果集。
			rs = pstm.executeQuery();
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
		return list;
	}

	public int update(Type type) {
		// TODO Auto-generated method stub
		return 0;
	}

}
