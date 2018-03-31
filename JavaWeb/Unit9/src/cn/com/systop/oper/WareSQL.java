package cn.com.systop.oper;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;

public class WareSQL {
	public void addMessage(MessageBean mesBean) throws Exception{
		try{
			Connection con=new DBConnection().getCon();
			PreparedStatement stm=con.prepareStatement("inset into Message values(?,?,?,?)");
			stm.setString(1, mesBean.getMessName());
			stm.setString(2,mesBean.getTitle());
			SimpleDateFormat dateFormat=new SimpleDateFormat("yyyy-MM-dd");
			Calendar ct=Calendar.getInstance();
			stm.setDate(3, java.sql.Date.valueOf(String.valueOf(dateFormat.format(ct.getTime()))));
			stm.setString(4,mesBean.getContent());
			try{
				int i=stm.executeUpdate();
			}catch(Exception e){
				e.printStackTrace();
			}
			con.close();
		}catch(Exception e){
			e.printStackTrace();
		}
	}
	public Collection getMessage() throws Exception{
		Collection met=new ArrayList();
		try{
			Connection con=new DBConnection().getCon();
			Statement stm=con.createStatement();
			ResultSet rst=null;
			rst=stm.executeQuery("select * from Message");
			while(rst.next()){
				String title = rst.getString("title");
				String messName=rst.getString("messName");
				String content=rst.getString("content");
				java.sql.Date messDate=rst.getDate("messDate");
				MessageBean messb=new MessageBean();
				messb.setMessName(messName);
				messb.setTitle(title);
				messb.setContent(content);
				messb.setMessDate(messDate);
				met.add(messb);
			}
			rst.close();
			stm.close();
			con.close();
		}catch(Exception e ){
			e.printStackTrace();
		}
		return met;
	}
}
