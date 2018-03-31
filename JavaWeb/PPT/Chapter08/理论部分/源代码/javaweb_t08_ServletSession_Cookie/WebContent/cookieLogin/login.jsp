<%@page import="java.net.URLDecoder"%>
<%@page import="java.net.URLEncoder"%>
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
		String strUserName = "";
		Cookie[] cookies = request.getCookies();
		if (cookies != null && cookies.length > 0) {
			for (Cookie c : cookies) {
				if (c.getName().equals("UserName")) {
					strUserName = c.getValue();
					//解码cookie
					strUserName=URLDecoder.decode(strUserName, "utf-8");
				}
			}
		}
	%>
	<form action="../LoginCookieServlet" method="post">
		用户名：<input type="text" name="name" value="<%=strUserName%>"> 
		<%-- <input type="text" name="name" value="${cookie.UserName.value }"> --%>
		<br>
		密码：<input type="password" name="password"><br> <input
			type="submit" value="登录">
	</form>
</body>
</html>