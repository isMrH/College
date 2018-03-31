<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Ê¹ÓÃjsp:forward×ª·¢ÇëÇó</title>
</head>
<body>
	<%
		String pageforward;
		if(Math.random() > 0.5){
			pageforward = "page1.jsp";
		}else{
			pageforward = "page2.jsp";
		}
	%>
	<%
		request.getRequestDispatcher("").forward(request, response);
	%>
	<jsp:forward page="<%=pageforward %>"></jsp:forward>
</body>
</html>