<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<table border="0">
		<c:forEach items="${list}" var="mess">
			<tr>
				<td>编号</td>
				<td>${mess.id }</td>
			</tr>
			<tr>
				<td>标题</td>
				<td>${mess.title }</td>
			</tr>
			<tr>
				<td>内容</td>
				<td>${mess.message }</td>
			</tr>
			<tr>
				<td colspan="2"><hr size="2"/></td>
			</tr>
		</c:forEach>
	</table>
</body>
</html>