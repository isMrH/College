<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<%@ page import="com.Movies" %>
<%@ page import="com.MySql" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Insert title here</title>
</head>
<body>
<%
	  request.setCharacterEncoding("utf-8");
	  //获取参数值
	  Movies movie = new Movies();
	  movie.setMovieName(request.getParameter("movieName"));
	  movie.setDirector(request.getParameter("director"));
	  movie.setStardom(request.getParameter("stardom"));
	  int typeid = Integer.parseInt(request.getParameter("typeid"));
	  movie.setTypeID(typeid);
	  movie.setRegion(request.getParameter("region"));
	  movie.setDescription(request.getParameter("description"));
	  movie.setShowtime(request.getParameter("showtime"));
	  movie.setMoviespic(request.getParameter("image"));
	  double price = Double.parseDouble(request.getParameter("price"));
	  movie.setPrice(price);
	  MySql ms=new MySql();
	  int res = ms.AddMovies(movie);
	  if(res>0){
		   
		   request.getRequestDispatcher("success.jsp").forward(request,response);
	  }else{
		   
		   request.getRequestDispatcher("error.jsp").forward(request,response);
	  }
%>
</body>
</html>