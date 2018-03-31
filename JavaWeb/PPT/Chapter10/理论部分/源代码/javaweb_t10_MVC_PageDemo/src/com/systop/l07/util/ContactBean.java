package com.systop.l07.util;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Vector;
import com.systop.l07.connection.DBConnection;
import com.systop.l07.bean.NewsBean;

public class ContactBean {
	private Connection conn;

	public Connection getConnection() {
		conn = DBConnection.getConnection();
		return conn;
	}

	/** *返回要查询的记录数 */
	public int getAvailableCount() throws Exception {
		int ret = 0;
		String strSql = "select count(*) from news";
		Connection conn = this.getConnection();
		Statement stmt = conn.createStatement();
		ResultSet rset = stmt.executeQuery(strSql);
		while (rset.next()) {
			ret = rset.getInt(1);
		}
		return ret;
	}

	/* 获取查寻的记录数 */
	public ArrayList getData(String topage, int pagecount)
			throws NumberFormatException, SQLException {
		String sql = "select * from news";
		Statement state = null;
		ResultSet rs = null;
		int pagesize = PageBean.pagesize;//3
		int showpage = 1;
		ArrayList list = new ArrayList();
		int j = 0;
		try {
			Connection conn = this.getConnection();
			state = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE,
					ResultSet.CONCUR_READ_ONLY);
			rs = state.executeQuery(sql);
		} catch (Exception e) {
			System.out.println("exception");
		}
		if (!rs.next()) {
			System.out.println("no records!");
		} else {
			rs.last();
			if (topage != null) {
				showpage = Integer.parseInt(topage);
				if (showpage > pagecount) {
					showpage = pagecount;
				} else if (showpage <= 0) {
					showpage = 1;
				}
			}
			rs.absolute((showpage - 1) * pagesize + 1);//定位数据行
			for (int i = 1; i <= pagesize; i++) {
				NewsBean news = new NewsBean();
				news.setNewsid(rs.getInt(1));
				news.setNewsContent(rs.getString(2));
				news.setNewsTitle(rs.getString(3));
				list.add(j, news);
				++j;
//				list.add(news);
				if (!rs.next())
					break;
			}

		}
		return list;
	}
}
