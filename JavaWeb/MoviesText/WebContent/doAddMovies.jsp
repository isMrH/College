<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.systop.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	request.setCharacterEncoding("UTF-8");
	//给实体类的各个属性赋值
	Movies movies=new Movies();
	movies.setMovieName(request.getParameter("movieName"));
	movies.setDirector(request.getParameter("director"));
	movies.setStardom(request.getParameter("stardom"));
	movies.setTypeID(Integer.parseInt(request.getParameter("type")));
	movies.setRegin(request.getParameter("regin"));
	movies.setShowtime(request.getParameter("showtime"));
	movies.setDescription(request.getParameter("description"));
	movies.setImage(request.getParameter("image"));
	movies.setPrice(Float.parseFloat(request.getParameter("price")));
	MoviesDao md=new MoviesDao();
	int row =md.saveMovies(movies);
	if (row>0){
		request.getRequestDispatcher("success.jsp").forward(request,response);
	}
	else{
		request.getRequestDispatcher("error.jsp").forward(request,response);
	}
%>
</body>
</html>