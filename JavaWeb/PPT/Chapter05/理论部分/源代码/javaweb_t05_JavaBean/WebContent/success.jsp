<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
    <jsp:useBean id="userRegister"
	class="cn.com.systop.t02.UserRegisterBean" scope="request"></jsp:useBean>
    
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>×¢²á³É¹¦</title>
</head>
<body>
<%=userRegister.toString() %>
</body>
</html>