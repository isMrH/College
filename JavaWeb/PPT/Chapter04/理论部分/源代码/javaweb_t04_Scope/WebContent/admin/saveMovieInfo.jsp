<%@ page language="java" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Movies" %>
<%@ page import="cn.com.systop.jspt06.dao.MoviesDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.MoviesDAOImpl" %>
<%
    //设置request编码的字符集方式，简体中文使用UTF-8字符集
	request.setCharacterEncoding("UTF-8");
	//下面获取表单元素的值,封装到Movies实体类对象中
	Movies movie = new Movies();
	movie.setMovieName(request.getParameter("movieName"));
	movie.setDirector(request.getParameter("director"));
	movie.setStardom(request.getParameter("stardom"));
	int typeID = Integer.parseInt(request.getParameter("typeID"));
	movie.setTypeID(typeID);
	movie.setRegion(request.getParameter("region"));
	movie.setShowtime(request.getParameter("showtime"));
	movie.setDescription(request.getParameter("description"));
	movie.setImage(request.getParameter("image"));
	double price = Double.parseDouble(request.getParameter("price"));
	movie.setPrice(price);
	//创建电影分类数据库访问类对象
  	MoviesDAO moviesDAO = new MoviesDAOImpl();
  	//调用电影分类添加方法
	int row = moviesDAO.save(movie);
	//根据返回结果判断是否添加成功
	if(row > 0){
		//添加成功转发到成功页面success.jsp
		request.getRequestDispatcher("/admin/success.jsp").forward(request,response);
	}else{
		//添加失败转发到失败页面error.jsp
		request.getRequestDispatcher("/admin/error.jsp").forward(request,response);
	}
%>