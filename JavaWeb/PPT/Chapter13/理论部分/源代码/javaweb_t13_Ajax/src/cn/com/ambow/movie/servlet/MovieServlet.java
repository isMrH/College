package cn.com.ambow.movie.servlet;

import java.io.IOException;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import cn.com.ambow.movie.dao.MovieDao;
import cn.com.ambow.movie.dao.TypeDao;
import cn.com.ambow.movie.pojo.Movie;

/**
 * Servlet implementation class MovieServlet
 */
public class MovieServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public MovieServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		this.doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		request.setCharacterEncoding("utf-8");
		String type = request.getParameter("type");
		MovieDao dao = new MovieDao();
		TypeDao tDao = new TypeDao();
		try {

			if (type.equals("list")) {
				// 取出列表，然后显示
				request.setAttribute("MovieList", dao.select());
				/*
				 * HttpSession session=request.getSession();
				 * session.setAttribute("MovieList", dao.select());
				 */
				request.getRequestDispatcher("/movielist.jsp").forward(request,
						response);
			} else if (type.equals("listpage")) {
				int pageIndex = Integer.parseInt(request.getParameter("page"));
				int pageSize = 10;
				ArrayList<Movie> list = new ArrayList<Movie>();
				String pageUrl = dao.select(pageIndex, pageSize, list,
						"MovieServlet");
				request.setAttribute("MovieList", list);
				request.setAttribute("PageUrl", pageUrl);
				request.getRequestDispatcher("/movielist_page.jsp").forward(
						request, response);

			} else if (type.equals("addsave")) {
				// 添加的保存
				String name = request.getParameter("MovieName");
				String date = request.getParameter("MovieDate");
				String director = request.getParameter("MovieDirector");
				String mtype = request.getParameter("MovieType");

				// 将数据添加的数据库中
				Movie m = new Movie(0, name, new java.sql.Date(
						new SimpleDateFormat("yyyy-MM-dd").parse(date)
								.getTime()), director, Integer.parseInt(mtype));
				dao.insert(m);
				// response.sendRedirect("MovieServlet?type=list");
				// 取出列表，然后显示
				request.setAttribute("MovieList", dao.select());
				request.getRequestDispatcher("/movielist.jsp").forward(request,
						response);
			} else if (type.equals("updatesave")) {
				// 修改的保存
				String id = request.getParameter("MovieID");
				String name = request.getParameter("MovieName");
				String date = request.getParameter("MovieDate");
				String director = request.getParameter("MovieDirector");
				String mtype = request.getParameter("MovieType");

				// 将数据添加的数据库中
				Movie m = new Movie(Integer.parseInt(id), name,
						new java.sql.Date(new SimpleDateFormat("yyyy-MM-dd")
								.parse(date).getTime()), director,
						Integer.parseInt(mtype));

				dao.update(m);
				// response.sendRedirect("MovieServlet?type=list");
				// 取出列表，然后显示
				request.setAttribute("MovieList", dao.select());
				request.getRequestDispatcher("/movielist.jsp").forward(request,
						response);
			} else if (type.equals("delete")) {
				// 删除
				int id = Integer.parseInt(request.getParameter("id"));
				dao.delete(id);
				
				request.setAttribute("MovieList", dao.select());
				request.getRequestDispatcher("/movielist.jsp").forward(request, response);
				
			} else if (type.equals("add")) {
				// 显示添加页面
				// 取出电影类型数据

				request.setAttribute("TypeList", tDao.getAllType());
				request.getRequestDispatcher("/addmovie.jsp").forward(request,
						response);
			} else if (type.equals("update")) {
				// 取得id
				int id = Integer.parseInt(request.getParameter("id"));// 
				Movie movie = dao.select(id);
				request.setAttribute("Movie", movie);
				request.setAttribute("TypeList", tDao.getAllType());
				request.getRequestDispatcher("/updatemovie.jsp").forward(
						request, response);
				// 转发到电影修改页面
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (NumberFormatException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
