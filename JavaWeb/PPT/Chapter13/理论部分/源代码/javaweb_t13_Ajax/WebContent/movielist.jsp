<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>

	<table border="1">
		<tr>
			<th>编号</th>
			<th>名称</th>
			<th>时间</th>
			<th>导演</th>
			<th>类型</th>
			<th>删除</th>
			<th>修改</th>
		</tr>
		<c:forEach items="${requestScope.MovieList }" var="m">
			<tr>
				<td>${m.movieID}</td>
				<td>${m.movieName }</td>
				<td>${m.showTime }</td>
				<td>${m.director }</td>
				<td>${m.typeName }</td>
				<td><a onclick="return confirm('确定要删除吗？')"
					href="MovieServlet?type=delete&id=${m.movieID}">删除</a></td>
				<td><a href="MovieServlet?type=update&id=${m.movieID }">修改</a></td>
			</tr>
		</c:forEach>
	</table>
</body>
</html>