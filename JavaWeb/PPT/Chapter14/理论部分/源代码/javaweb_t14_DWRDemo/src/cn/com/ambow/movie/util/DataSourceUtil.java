package cn.com.ambow.movie.util;

import javax.naming.Context;
import javax.naming.InitialContext;
import javax.naming.NamingException;
import javax.sql.DataSource;

/**
 * 单例模式生成DataSource对象
 * @author Administrator
 *
 */
public class DataSourceUtil {

	private static DataSource dataSource;
	
	static{
		Context ct = null;
		try {
			ct = new InitialContext();
			dataSource=(DataSource) ct.lookup("java:comp/env/jdbc/cms");//配置文件中的名称。
		} catch (NamingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	private DataSourceUtil(){
		
	}
	
	public static DataSource getDataSource(){
		return dataSource;
	}
}
