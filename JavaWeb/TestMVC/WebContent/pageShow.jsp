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
		<tr>
			<td colspan="2">
				<a href="/TestMVC/PageServlet?pageNo=1">首页</a>&nbsp;&nbsp;&nbsp;
				<a href="/TestMVC/PageServlet?pageNo=${pageNo-1 }">上一页</a>&nbsp;&nbsp;&nbsp;
				<a href="/TestMVC/PageServlet?pageNo=${pageNo+1 }">下一页</a>&nbsp;&nbsp;&nbsp;
				<a href="/TestMVC/PageServlet?pageNo=${maxPageNo}">末页</a>
				<select name="pageSize">
					<c:choose>
						<c:when test="${pageSize == 3}">
							<option value="3" selected="selected">3</option>
							<option value="5">5</option>
							<option value="10">10</option>
						</c:when>
						<c:when test="${pageSize == 5}">
							<option value="3">3</option>
							<option value="5" selected="selected">5</option>
							<option value="10">10</option>
						</c:when>
						<c:otherwise>
							<option value="10" selected="selected">10</option>
						</c:otherwise>
					</c:choose>
				</select>
			</td>
		</tr>
	</table>
</body>
</html>