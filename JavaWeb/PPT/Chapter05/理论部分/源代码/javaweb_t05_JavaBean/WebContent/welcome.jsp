<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Ê¹ÓÃjsp:useBean±ê×¼¶¯×÷</title>
</head>
<body>

	<%
		cn.com.systop.t02.User user = new cn.com.systop.t02.User();  
	%>
	<%=user.welcome() %>
</body>
</html>