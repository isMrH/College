<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>
<head>
</head>
<body>
	<form action="#">
		<table border="1" width="300px" bordercolor="black">
			<tr>
				<th>编号</th>
				<th>标题</th>
			</tr>
			<c:forEach items="${news1}" var="news2" varStatus="status">
				<tr>
					<td>${news2.newsid }
					<td>${news2.newsTitle}</td>
				</tr>
			</c:forEach>
		</table>
		<br />
		<c:if test="${showpage>1}">
			<a href="pageservlet?topage=<%=1%>">首页</a>
			<a href="pageservlet?topage=${showpage-1}">上一页</a>
		</c:if>
		<c:if test="${showpage<pagecount}">
			<a href="pageservlet?topage=${showpage+1}">下一页</a>
			<a href="pageservlet?topage=${pagecount}">最后一页</a>
		</c:if>
		第${showpage}页&nbsp;&nbsp;共${pagecount}页
	</form>
	<br>
</html>