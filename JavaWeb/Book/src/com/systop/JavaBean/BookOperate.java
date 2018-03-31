package com.systop.JavaBean;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Collection;

import com.systop.DB.DBCon;
	
public class BookOperate {
	//查询全部图书信息
	public Collection<BookBean> getAllBook(){
		Collection<BookBean> col=new ArrayList<BookBean>();
		Connection con=null;
		Statement stmt=null;
		ResultSet ret=null;
		String res="select * from t_books";
		try{
			con=DBCon.getCon();
			stmt=con.createStatement();
			ret=stmt.executeQuery(res);
			while(ret.next()){
				BookBean bi=new BookBean();
				bi.setAuthor(ret.getString("author"));
				bi.setBookID(ret.getInt("bookId"));
				bi.setBookName(ret.getString("bookName"));
				bi.setPubName(ret.getString("pubName"));
				bi.setPrice(ret.getFloat("price"));
				col.add(bi);			
			}
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			try{
				ret.close();
				stmt.close();
				con.close();
			}catch(SQLException ex){
				ex.printStackTrace();
			}	
		}
		return col;
	}
	
	//按图书编号查找图书信息
	public BookBean getBookByID(int id){
		BookBean bi= new BookBean();
		Connection con=null;
		Statement stmt=null;
		ResultSet ret=null;
		String res="Select * from t books where bookID="+id;
		try{
			con=DBCon.getCon();
			stmt=con.createStatement();
			ret=stmt.executeQuery(res);
			if(ret.next()){				
				bi.setAuthor(ret.getString("author"));
				bi.setBookID(ret.getInt("bookId"));
				bi.setBookName(ret.getString("bookName"));
				bi.setPubName(ret.getString("pubName"));
				bi.setPrice(ret.getFloat("price"));						
			}
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			try{
				ret.close();
				stmt.close();
				con.close();
			}catch(SQLException ex){
				ex.printStackTrace();
			}	
		}
		return bi;
	}
	
	
	//按照图书名称查找图书信息
	public Collection<BookBean> getBooksByBookName(String bookName){
		Collection<BookBean> col=new ArrayList<BookBean>();
		Connection con = null;
		Statement stmt=null;
		ResultSet ret=null;
		String res="select * from t_books where where bookName like ('%"+bookName+"%')";
		try{
			con=DBCon.getCon();
			stmt=con.createStatement();
			ret=stmt.executeQuery(res);
			while(ret.next()){
				BookBean bi=new BookBean();
				bi.setAuthor(ret.getString("author"));
				bi.setBookID(ret.getInt("bookId"));
				bi.setBookName(ret.getString("bookName"));
				bi.setPubName(ret.getString("pubName"));
				bi.setPrice(ret.getFloat("price"));
				col.add(bi);			
			}
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			try{
				ret.close();
				stmt.close();
				con.close();
			}catch(SQLException ex){
				ex.printStackTrace();
			}	
		}
		return col;
	}
}
