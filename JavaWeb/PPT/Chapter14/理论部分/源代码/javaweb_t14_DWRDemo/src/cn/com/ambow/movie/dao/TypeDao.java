package cn.com.ambow.movie.dao;

import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import cn.com.ambow.movie.pojo.Type;
import cn.com.ambow.movie.util.DBUtil;

public class TypeDao {
	public ArrayList<Type> getAllType() throws SQLException,
			ClassNotFoundException, IOException {
		ArrayList<Type> list = new ArrayList<Type>();
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select * from type";
		ResultSet rs = db.execQuery(sql, null);
		while (rs.next()) {
			Type t = new Type(rs.getInt("typeid"), rs.getString("typename"));
			list.add(t);
		}
		db.closeConnection();
		return list;
	}
}
