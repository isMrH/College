package cn.com.ambow.test;

import java.io.IOException;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;

import cn.com.ambow.movie.dao.MovieDao;
import cn.com.ambow.movie.pojo.Movie;

public class MovieManager {

	private MovieDao dao = new MovieDao();

	/**
	 * 连接数据库返回泛型集合
	 * @return
	 */
	public ArrayList<Movie> select() {
		try {
			return dao.select();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	/**
	 * 返回集合对象
	 * @return
	 */
	public ArrayList getList() {
		ArrayList list = new ArrayList();
		
		//1.直接添加对象
		/*list.add("aaaa"); 
		list.add("bbbb"); 
		list.add(123); 
		list.add(456);*/
		
		//2.添加地定义对象。
		list.add(new Dog("嘿嘿", "黑贝"));
		list.add(new Dog("白白", "萨摩耶"));
		list.add(new Dog("黄黄", "松狮"));
		list.add(new Dog("壮壮", "藏獒"));
		return list;
	}

	public HashMap getMap() {
		HashMap hm = new HashMap();
		
		//1.添加字符串对象
		 /*hm.put("aaa", "aaaaaaaaa"); 
		 hm.put("bbb", "bbbbbbbb"); 
		 hm.put("ccc", "ccccccc"); 
		 hm.put("ddd", "ddddddddddd");*/
		 
		 //2.添加自定义对象
		hm.put("hihi", new Dog("嘿嘿", "黑贝"));
		hm.put("baba", new Dog("白白", "萨摩耶"));
		hm.put("huhu", new Dog("黄黄", "松狮"));
		hm.put("zhzh", new Dog("壮壮", "藏獒"));
		return hm;
	}

}
