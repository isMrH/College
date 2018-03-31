<%@page import="cn.com.ambow.bean.User"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		User user=(User)session.getAttribute("user");
		if(user==null){
			response.sendRedirect("login.html");
		}else{
			out.print("欢迎你："+user.getUserName());
		}
	%>
</body>
</html>