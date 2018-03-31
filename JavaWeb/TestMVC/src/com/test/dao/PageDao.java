package com.test.dao;

import java.util.ArrayList;
import java.util.List;

import com.test.model.Message;

public class PageDao extends BaseDao {

	/**
	 * 查询所有数据，不分页
	 * @return
	 */
	public List findAll(){
		//定义返回结构集合
		List list = new ArrayList();
		
		//定义sql语句
		String sql = "select * from T_Message";
		try {
			//连接数据库
			super.getConnection();
			//预处理语句
			pstm = con.prepareStatement(sql);
			//执行语句
			rs = pstm.executeQuery();
			//处理结果
			while(rs.next()){
				//把数据库的每列字段都放入一个对象属性里
				Message message = new Message();
				message.setId(rs.getInt("id"));
				message.setTitle(rs.getString("title"));
				message.setMessage(rs.getString("message"));
				//把每个对象都存入集合
				list.add(message);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//关闭所有连接
			super.closeAll();
		}
		//返回最终的集合
		return list;
	}
	
	/**
	 * 获取最大条数
	 * @return
	 */
	public int maxSize(){
		int num = 0;
		//定义sql语句
		String sql = "select count(*) from T_Message";
		try {
			//连接数据库
			super.getConnection();
			//预处理语句
			pstm = con.prepareStatement(sql);
			//执行语句
			rs = pstm.executeQuery();
			//处理结果
			if(rs.next()){
				num = rs.getInt(1);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//关闭所有连接
			super.closeAll();
		}
		//返回最终的条数
		return num;
	}
	
	
	public List findPage(int pageNo,int pageSize){
		//定义返回结构集合
		List list = new ArrayList();
		
		//定义sql语句
		String sql = "select top "+pageSize+" * from T_Message " +
				"where id not in (select top "+(pageSize*(pageNo-1))+" id from T_Message order by id) order by id";
		try {
			//连接数据库
			super.getConnection();
			//预处理语句
			pstm = con.prepareStatement(sql);
			
			//执行语句
			rs = pstm.executeQuery();
			//处理结果
			while(rs.next()){
				//把数据库的每列字段都放入一个对象属性里
				Message message = new Message();
				message.setId(rs.getInt("id"));
				message.setTitle(rs.getString("title"));
				message.setMessage(rs.getString("message"));
				//把每个对象都存入集合
				list.add(message);
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally{
			//关闭所有连接
			super.closeAll();
		}
		//返回最终的集合
		return list;
	}
}
