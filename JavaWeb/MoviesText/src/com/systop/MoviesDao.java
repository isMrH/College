package com.systop;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class MoviesDao {
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
     *  ��ӵ�Ӱ
     */
	public int saveMovies(Movies movies){
		int row=0;
		String sql="insert into movies values(?,?,?,?,?,?,?,?,?)";
		try {
			con=DBConn.getCon();
			pstmt=con.prepareStatement(sql);
			pstmt.setString(1, movies.getMovieName());
			pstmt.setString(2, movies.getDirector());
			pstmt.setInt(3, movies.getTypeID());
			pstmt.setString(4, movies.getStardom());
			pstmt.setString(5, movies.getRegin());
			pstmt.setString(6, movies.getShowtime());
			pstmt.setString(7, movies.getDescription());
			pstmt.setString(8, movies.getImage());
			pstmt.setDouble(9, movies.getPrice());
			row=pstmt.executeUpdate();//������Ӱ��ļ�¼����
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
	/**
     *  ��ѯ��Ӱ
     */
    public List searchMovies(int typeid){
    	List list = new ArrayList();
    	Connection con = null;
    	PreparedStatement pstmt = null;
    	ResultSet rs = null;
    	String sql = "select * from movies where typeid=?";
    	try{
    		con=DBConn.getCon();
            pstmt=con.prepareStatement(sql);
            pstmt.setInt(1, typeid);
            rs=pstmt.executeQuery();
            while(rs.next()){
            	Movies m=new Movies();
                m.setMovieID(rs.getInt("movieID"));
                m.setMovieName(rs.getString("movieName"));
                m.setDirector(rs.getString("director"));
                m.setTypeID(rs.getInt("typeID"));
                m.setStardom(rs.getString("stardom"));
                m.setRegin(rs.getString("region"));
                m.setShowtime(rs.getString("showTime"));
                m.setDescription(rs.getString("description"));
                m.setImage(rs.getString("image"));
                m.setPrice(rs.getFloat("price"));
                list.add(m);
            }
        }catch(Exception ex){
            ex.printStackTrace();
        }finally{
            try{
                pstmt.close();
                con.close();
            }catch(Exception ex){
                ex.printStackTrace();
            }
        }
        return list;
    }
}
