package cn.com.ambow.movie.dao;

import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import cn.com.ambow.movie.pojo.Movie;
import cn.com.ambow.movie.util.DBUtil;

public class MovieDao {
	public Movie select(int id) throws SQLException, ClassNotFoundException,
			IOException {
		Movie movie = null;
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select a.*,b.typename from movies a,type b where a.typeid=b.typeid and a.movieid=?";
		ArrayList params = new ArrayList();
		params.add(id);
		ResultSet rs = db.execQuery(sql, params);
		if (rs.next()) {
			movie = new Movie(rs.getInt("movieid"), rs.getString("moviename"),
					rs.getDate("showtime"), rs.getString("director"),
					rs.getInt("typeid"), rs.getString("stardom"),
					rs.getString("region"), rs.getString("description"),
					rs.getString("image"), rs.getDouble("price"),
					rs.getString("typename"));
		}
		db.closeConnection();
		return movie;
	}

	public void delete(int id) throws SQLException, ClassNotFoundException,
			IOException {
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "delete from movies where movieid=?";
		ArrayList params = new ArrayList();
		params.add(id);

		db.execUpdate(sql, params);
		db.closeConnection();
	}

	public void update(Movie movie) throws SQLException,
			ClassNotFoundException, IOException {
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "update movies set moviename=?,director=?,typeid=?,stardom=?,"
				+ "region=?,showtime=?,description=?,image=?,price=? "
				+ "where movieid=?";
		ArrayList params = new ArrayList();
		params.add(movie.getMovieName());
		params.add(movie.getDirector());
		params.add(movie.getTypeID());
		params.add(movie.getStardom());
		params.add(movie.getRegion());
		params.add(movie.getShowTime());
		params.add(movie.getDescription());
		params.add(movie.getImage());
		params.add(movie.getPrive());
		params.add(movie.getMovieID());
		db.execUpdate(sql, params);
		db.closeConnection();
	}

	public void insert(Movie movie) throws SQLException,
			ClassNotFoundException, IOException {
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "insert into movies(moviename,director,typeid,stardom,region,showtime,description,image,price) values(?,?,?,?,?,?,?,?,?)";
		ArrayList params = new ArrayList();
		params.add(movie.getMovieName());
		params.add(movie.getDirector());
		params.add(movie.getTypeID());
		params.add(movie.getStardom());
		params.add(movie.getRegion());
		params.add(movie.getShowTime());
		params.add(movie.getDescription());
		params.add(movie.getImage());
		params.add(movie.getPrive());
		db.execUpdate(sql, params);
		db.closeConnection();
	}

	public ArrayList<Movie> select() throws SQLException,
			ClassNotFoundException, IOException {
		ArrayList<Movie> list = new ArrayList<Movie>();
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select a.*,b.typename from movies a,type b where a.typeid=b.typeid order by movieid";
		ResultSet rs = db.execQuery(sql, null);
		while (rs.next()) {
			Movie m = new Movie(rs.getInt("movieid"),
					rs.getString("moviename"), rs.getDate("showtime"),
					rs.getString("director"), rs.getInt("typeid"),
					rs.getString("stardom"), rs.getString("region"),
					rs.getString("description"), rs.getString("image"),
					rs.getDouble("price"), rs.getString("typename"));
			list.add(m);
		}
		db.closeConnection();
		return list;
	}

	public String select(int pageIndex, int pageSize, ArrayList<Movie> list,
			String url) throws SQLException, ClassNotFoundException,
			IOException {
		String pageUrl = "";
		DBUtil db = new DBUtil();
		db.openConnection();

//		String sql = "select top "+pageSize+" a.*,b.typename " +
//				"from movies a,type b " +
//				"where a.typeid=b.typeid " +
//				"and a.movieid not in " +
//				"(select top "+((pageIndex - 1) * pageSize)+" a.movieid " +
//						"from movies a,type b " +
//						"where a.typeid=b.typeid order by a.movieid asc)" +
//						" order by a.movieid asc";

//		ArrayList params = new ArrayList();
//		params.add(pageSize);
//		params.add((pageIndex - 1) * pageSize);

		String sql="select a.*,b.typename from movies a,type b where a.typeid=b.typeid order by movieid asc limit "+pageIndex+","+pageSize;
		System.out.println(sql);
		ResultSet rs = db.execQuery(sql, null);
		while (rs.next()) {
			Movie m = new Movie(rs.getInt("movieid"),
					rs.getString("moviename"), rs.getDate("showtime"),
					rs.getString("director"), rs.getInt("typeid"),
					rs.getString("stardom"), rs.getString("region"),
					rs.getString("description"), rs.getString("image"),
					rs.getDouble("price"), rs.getString("typename"));
			list.add(m);
		}
		rs.close();
		rs = db.execQuery("select count(*) from movies", null);
		rs.next();
		int rowCount = rs.getInt(1);
		int pageCount = rowCount % pageSize == 0 ? rowCount / pageSize
				: rowCount / pageSize + 1;
		String firstUrl = "&nbsp;<a href='" + url
				+ "?type=listpage&page=1'>首页</a>&nbsp;";
		String previousUrl = "&nbsp;<a href='" + url + "?type=listpage&page="
				+ (pageIndex - 1) + "'>上一页</a>&nbsp;";
		String nextUrl = "&nbsp;<a href='" + url + "?type=listpage&page="
				+ (pageIndex + 1) + "'>下一页</a>&nbsp;";
		String lastUrl = "&nbsp;<a href='" + url + "?type=listpage&page="
				+ pageCount + "'>最后页</a>&nbsp;";

		if (pageCount > 1) {
			if (pageIndex == 1) {
				pageUrl = nextUrl + lastUrl;
			} else if (pageIndex == pageCount) {
				pageUrl = firstUrl + previousUrl;
			} else {
				pageUrl = firstUrl + previousUrl + nextUrl + lastUrl;
			}
		}

		rs.close();
		db.closeConnection();
		return pageUrl;
	}

	/*
	 * select * from (select emp.*,row_number() over(order by empno) as rowindex
	 * from emp) t where rowindex between 起始索引 and 结束索引
	 */
	public ArrayList<Movie> getAllMovieOracle(int pageIndex, int pageSize)
			throws SQLException, ClassNotFoundException, IOException {
		ArrayList<Movie> list = new ArrayList<Movie>();
		DBUtil db = new DBUtil();
		db.openConnection();

		String sql = "select * from "
				+ " (select row_number() over (order by a.movieid) as rowindex,"
				+ " a.*,b.typername from t_movie a,t_type b "
				+ " where a.movietype=b.typeid) t "
				+ " where rowindex between ? and ?";
		int beginIndex = (pageIndex - 1) * pageSize + 1;
		int endIndex = pageIndex * pageSize;
		ArrayList params = new ArrayList();
		params.add(beginIndex);
		params.add(endIndex);
		ResultSet rs = db.execQuery(sql, params);
		while (rs.next()) {
			Movie m = new Movie(rs.getInt("movieid"),
					rs.getString("moviename"), rs.getDate("moviedate"),
					rs.getString("moviedirector"), rs.getInt("movietype"),
					rs.getString("typername"));
			list.add(m);
		}
		db.closeConnection();
		return list;
	}

	public String getAllMovieOracleUrl(int pageIndex, int pageSize)
			throws SQLException, ClassNotFoundException, IOException {
		String pageUrl = "";
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select count(*) from t_movie";
		ResultSet rs = db.execQuery(sql, null);
		rs.next();
		int rowCount = rs.getInt(1);
		int pageCount = rowCount % pageSize == 0 ? rowCount / pageSize
				: (rowCount / pageSize) + 1;

		String firstUrl = "&nbsp;<a href='movielistpage.jsp?page=1'>首页</a>&nbsp;";
		String previousUrl = "&nbsp;<a href='movielistpage.jsp?page="
				+ (pageIndex - 1) + "'>上页</a>&nbsp;";
		String nextUrl = "&nbsp;<a href='movielistpage.jsp?page="
				+ (pageIndex + 1) + "'>下页</a>&nbsp;";
		String lastUrl = "&nbsp;<a href='movielistpage.jsp?page=" + pageCount
				+ "'>末页</a>&nbsp;";
		// The king is always lucky; //王老吉
		if (pageCount > 1) {
			if (pageIndex == 1) {
				pageUrl = nextUrl + lastUrl;
			} else if (pageIndex == pageCount) {
				pageUrl = firstUrl + previousUrl;
			} else {
				pageUrl = firstUrl + previousUrl + nextUrl + lastUrl;
			}
		}

		db.closeConnection();
		return pageUrl;
	}

	/*
	 * public void a(){ String p="bb"; aa(p);
	 * 
	 * } public void aa(String p){ p="aaa"; }
	 */

	public String getAllMovieMySQL(int pageIndex, int pageSize,
			ArrayList<Movie> list) throws SQLException, ClassNotFoundException,
			IOException {
		String pageUrl = "";
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select a.*,b.typename from t_movie a,t_type b "
				+ " where a.movietype=b.typeid order by a.movieid limit ?,?";
		int beginIndex = (pageIndex - 1) * pageSize;
		System.out.println(beginIndex);
		ArrayList params = new ArrayList();
		params.add(beginIndex);
		params.add(pageSize);
		ResultSet rs = db.execQuery(sql, params);
		while (rs.next()) {
			Movie m = new Movie(rs.getInt("movieid"),
					rs.getString("moviename"), rs.getDate("moviedate"),
					rs.getString("moviedirector"), rs.getInt("movietype"),
					rs.getString("typename"));
			list.add(m);
		}
		rs.close();

		sql = "select count(*) from t_movie";
		rs = db.execQuery(sql, null);
		rs.next();
		int rowCount = rs.getInt(1);
		int pageCount = rowCount % pageSize == 0 ? rowCount / pageSize
				: (rowCount / pageSize) + 1;

		String firstUrl = "&nbsp;<a href='movielistpage1.jsp?page=1'>首页</a>&nbsp;";
		String previousUrl = "&nbsp;<a href='movielistpage1.jsp?page="
				+ (pageIndex - 1) + "'>上页</a>&nbsp;";
		String nextUrl = "&nbsp;<a href='movielistpage1.jsp?page="
				+ (pageIndex + 1) + "'>下页</a>&nbsp;";
		String lastUrl = "&nbsp;<a href='movielistpage1.jsp?page=" + pageCount
				+ "'>末页</a>&nbsp;";
		// The king is always lucky; //王老吉
		if (pageCount > 1) {
			if (pageIndex == 1) {
				pageUrl = nextUrl + lastUrl;
			} else if (pageIndex == pageCount) {
				pageUrl = firstUrl + previousUrl;
			} else {
				pageUrl = firstUrl + previousUrl + nextUrl + lastUrl;
			}
		}

		db.closeConnection();
		return pageUrl;
	}

	public String getAllMovieMySQLByPageIndex(int pageIndex, int pageSize,
			ArrayList<Movie> list) throws SQLException, ClassNotFoundException,
			IOException {
		String pageUrl = "";
		DBUtil db = new DBUtil();
		db.openConnection();
		String sql = "select a.*,b.typename from t_movie a,t_type b "
				+ " where a.movietype=b.typeid order by a.movieid limit ?,?";
		int beginIndex = (pageIndex - 1) * pageSize;
		System.out.println(beginIndex);
		ArrayList params = new ArrayList();
		params.add(beginIndex);
		params.add(pageSize);
		ResultSet rs = db.execQuery(sql, params);
		while (rs.next()) {
			Movie m = new Movie(rs.getInt("movieid"),
					rs.getString("moviename"), rs.getDate("moviedate"),
					rs.getString("moviedirector"), rs.getInt("movietype"),
					rs.getString("typename"));
			list.add(m);
		}
		rs.close();

		sql = "select count(*) from t_movie";
		rs = db.execQuery(sql, null);
		rs.next();
		int rowCount = rs.getInt(1);
		int pageCount = rowCount % pageSize == 0 ? rowCount / pageSize
				: (rowCount / pageSize) + 1;

		String firstUrl = "&nbsp;<a href='movielistpage1.jsp?page=1'>首页</a>&nbsp;";
		String previousUrl = "&nbsp;<a href='movielistpage1.jsp?page="
				+ (pageIndex - 1) + "'>上页</a>&nbsp;";
		String nextUrl = "&nbsp;<a href='movielistpage1.jsp?page="
				+ (pageIndex + 1) + "'>下页</a>&nbsp;";
		String lastUrl = "&nbsp;<a href='movielistpage1.jsp?page=" + pageCount
				+ "'>末页</a>&nbsp;";
		// The king is always lucky; //王老吉
		StringBuffer sb = new StringBuffer();
		if (pageCount > 1) {
			int rb = 0, rcount = 0;
			if (pageIndex <= 7) {
				rb = 1;
				rcount = 8;
			} else if (pageIndex >= pageCount - 7 && pageIndex <= pageCount) {
				rb = pageCount - 8;
				rcount = pageCount;
			} else {
				rb = pageIndex - 4;
				rcount = pageIndex + 4;
			}

			if (pageIndex == 1) {
				for (int i = rb; i <= rcount; i++) {
					String url = "";
					if (i == pageIndex) {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'><b><font color='red'>" + i
								+ "</font></b></a>&nbsp;";
					} else {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'>" + i + "</a>&nbsp;";
					}
					sb.append(url);
				}
				sb.append(nextUrl);
				sb.append(lastUrl);
			} else if (pageIndex == pageCount) {

				sb.append(firstUrl);
				sb.append(previousUrl);
				for (int i = rb; i <= rcount; i++) {
					String url = "";
					if (i == pageIndex) {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'><b><font color='red'>" + i
								+ "</font></b></a>&nbsp;";
					} else {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'>" + i + "</a>&nbsp;";
					}
					sb.append(url);
				}
			} else {
				sb.append(firstUrl);
				sb.append(previousUrl);
				for (int i = rb; i <= rcount; i++) {
					String url = "";
					if (i == pageIndex) {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'><b><font color='red'>" + i
								+ "</font></b></a>&nbsp;";
					} else {
						url = "&nbsp;<a href='movielistpage1.jsp?page=" + i
								+ "'>" + i + "</a>&nbsp;";
					}
					sb.append(url);
				}
				sb.append(nextUrl);
				sb.append(lastUrl);
			}
		}
		pageUrl = sb.toString();

		db.closeConnection();
		return pageUrl;
	}
}
