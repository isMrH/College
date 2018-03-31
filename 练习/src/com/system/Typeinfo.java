package com.system;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;



public class Typeinfo extends DAO {
	public List find(){
		//连接语句
		String sql = "select * from type";
		
		List list = new ArrayList();
		super.con = super.getConn();
		try {
			super.stmt = con.createStatement();
			super.rs = stmt.executeQuery(sql);
			//处理结果
			while (rs.next()) {
				Type type = new Type();
				int typeid = rs.getInt("typeID");
				String typename = rs.getString("typename");
				
				type.setTypeID(typeid);
				type.setTypename(typename);
				list.add(type);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			super.closeAll();
		}
		return list;
	}
	public int save(Type type){
		int row=0;
		String sql="insert into type values(?)";
		try{
			super.getConn();
			pstm=con.prepareStatement(sql);
			pstm.setString(1,type.getTypename());
			row=pstm.executeUpdate();	
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			super.closeAll();
		}
		return row;
	}
}
