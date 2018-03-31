package cn.com.systop.sql;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;

import cn.com.systop.JavaBean.DBCon;
import cn.com.systop.JavaBean.WareBean;

public class wareSql {
	public void addWare(WareBean wareBean) throws Exception{
		try{
			Connection con=new DBCon().getCon();
			PreparedStatement stm=con.prepareStatement("inset into wareTable values(?,?,?)");
			stm.setString(1, wareBean.getWareName());
			stm.setInt(2,wareBean.getWareSort());			
			stm.setInt(3,wareBean.getWareAmount());
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
	public Collection getWare() throws Exception{
		Collection met=new ArrayList();
		try{
			Connection con=new DBCon().getCon();
			Statement stm=con.createStatement();
			ResultSet rst=null;
			rst=stm.executeQuery("select * from wareTable");
			while(rst.next()){
				String wareName = rst.getString("wareName");
				int wareSort= Integer.parseInt(rst.getString("wareSort"));
				int wareAmmount=Integer.parseInt(rst.getString("wareAmmount"));
				WareBean ware=new WareBean();
				ware.setWareName(wareName);
				ware.setWareSort(wareSort);
				ware.setWareAmount(wareAmmount);					
				met.add(ware);
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
