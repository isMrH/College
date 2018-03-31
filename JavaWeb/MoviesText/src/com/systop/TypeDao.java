package com.systop;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;

public class TypeDao {
	//连接数据库的url
    String url = "jdbc:sqlserver://localhost:1433;databaseName=Movie";
    //连接数据库用户名
    String user = "sa";
    //连接数据库密码
    String password = "sa";
    //定义连接对象
    Connection con = null;
    //定义statement对象
    Statement stmt = null;
    //定义PreparedStatement对象
    PreparedStatement pstmt = null;
    //结果集对象
    ResultSet rs = null;
    /**
     * 查询所有类型
     */
    public List<Type> getType(){
        List list=new ArrayList();
        String sql="select * from type";
        try{
            con=DBConn.getCon();
            pstmt=con.prepareStatement(sql);
            rs=pstmt.executeQuery();
            while(rs.next()){
                Type type=new Type();
                type.setTypeID(rs.getInt("typeID"));
                type.setTypeName(rs.getString("typeName"));
                list.add(type);
            }
        }
        catch(Exception ex){
            ex.printStackTrace();
        }
        finally{
            try{
                rs.close();
                pstmt.close();
                con.close();
            }
            catch(Exception ex){
                ex.printStackTrace();
            }
        }
        return list;
    }
    /**
     * 添加类型
     */
    public int savaType(Type type){
    	int row=0; 
    	String sql="insert into type values(?)";
    	try {
    		con=DBConn.getCon();
    		pstmt=con.prepareStatement(sql);
    		pstmt.setString(1, type.getTypeName());
    		row=pstmt.executeUpdate();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		finally{
			try{
                rs.close();
                pstmt.close();
                con.close();
            }
            catch(Exception ex){
                ex.printStackTrace();
            }
		}
    	return row;
    }
    
    
    
    
    
    
    
    
    
    
}
