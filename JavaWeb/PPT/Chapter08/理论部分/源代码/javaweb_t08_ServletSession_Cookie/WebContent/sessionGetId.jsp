<%@page import="java.util.Date"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%--1.jsp中session是内置对象，无需创建，即可直接使用 --%>
	<%-- session id:<%=session.getId()%><br/> --%>
	<%--2.第一次请求时，显示ture，后续请求时，只要sessino没有销毁，则为false --%>
	<%-- session is new:<%=session.isNew()%><br/> --%>
	<%--3.在jsp的页面中，是可以禁用session对象的 --%>
	<%--在page指令中，设置session为false则页面中无法使用sessino内置对象 --%>
	<%--但是可以使用自定义的session对象 --%>
	<%--
		HttpSession session = request.getSession();
		out.print(session.getId());
	--%>
	<%--4.设置sessin过期时间 --%>
	<%-- <%
		session.setMaxInactiveInterval(2);
	%>
	session is new:<%=session.isNew()%><br> --%>
	<%--5.获取创建时间 --%>
	session的创建时间：<%=new Date(session.getCreationTime())%><br>
	session的上次请求时间：<%=new Date(session.getLastAccessedTime())%><br>
</body>
</html>