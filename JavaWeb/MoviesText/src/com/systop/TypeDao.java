package com.systop;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;

public class TypeDao {
	//�������ݿ��url
    String url = "jdbc:sqlserver://localhost:1433;databaseName=Movie";
    //�������ݿ��û���
    String user = "sa";
    //�������ݿ�����
    String password = "sa";
    //�������Ӷ���
    Connection con = null;
    //����statement����
    Statement stmt = null;
    //����PreparedStatement����
    PreparedStatement pstmt = null;
    //���������
    ResultSet rs = null;
    /**
     * ��ѯ��������
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
     * �������
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
