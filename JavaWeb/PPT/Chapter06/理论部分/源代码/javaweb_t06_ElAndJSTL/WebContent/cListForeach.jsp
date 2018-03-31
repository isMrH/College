<%@ page contentType="text/html;charset=GB2312" import="java.util.*"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
<head>
<title>c:forEach</title>
</head>
<body>
<%
	List userList = new ArrayList();
	userList.add("jack");
	userList.add("green");
	userList.add("lucy");
	request.setAttribute("userList",userList);
%>
	<c:forEach var="username" items="${userList}">
		${username}<br>
	</c:forEach>
</body>
</html>

