<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<%@ page import="com.Type" %>
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
   String typename = request.getParameter("typename");
   Type type = new Type();
   type.setTypeName(typename);
   MySql ms = new MySql();
   int res = ms.AddType(type);
   if(res>0){
	   
	   request.getRequestDispatcher("success.jsp").forward(request,response);
   }else{
	   
	   request.getRequestDispatcher("error.jsp").forward(request,response);
   }
%>
</body>
</html>