<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>
<%@ page import="com.systop.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<%
	request.setCharacterEncoding("UTF-8");
	String userName=request.getParameter("userName");
	String passWord=request.getParameter("passWord");
	
	Users loginedUser=null;
	UsersDao usersDAO=new UsersDao();
	
	loginedUser=usersDAO.doLogin(userName,passWord);
	if(loginedUser !=null){
		session.setAttribute("LOGINED_USER",loginedUser);
		response.sendRedirect("MoviesText/admin.jsp");
	}else{
		response.sendRedirect("MoviesText/Login.jsp");
	}
	%>
</body>
</html>