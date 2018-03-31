<%@page import="cn.com.ambow.bean.Person"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%--prefix为标签前缀，前缀写什么，标签就以什么为前缀 --%>
<%--如前缀为：c，标签以c开头，如前缀为：core，标签以core开头 --%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%--set标签 --%>
	<%--基础数据赋值 --%>
	<c:set var="movie" value="画皮II"></c:set>
	<c:out value="${movie }"></c:out>
	${movie }
	<hr>
	<%--引用数据赋值 --%>
	<%
		Person person = new Person();
		pageContext.setAttribute("p", person);
	%>
	<%--使用set方式实现 --%>
	<c:set value="小唯" target="${p }" property="name"></c:set>
	<c:set value="雀儿" target="${p.dog }" property="name"></c:set>
	${p.name }
	<br> ${p.dog.name }
	<hr>
	<%--移除变量 --%>
	<c:remove var="movie" />
	movie已移除：${movie } empty movie:${empty movie }
</body>
</html>