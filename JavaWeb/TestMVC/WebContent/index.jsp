<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<frameset rows="120,*,50">
	<frame name="top" src="login.jsp" />
	<frameset cols="150,*">
		<frame name="menu" src="menu.jsp"/>
		<frame name="main" src="welcome.jsp"/>
	</frameset>
	<frame name="foot" src="login.jsp"/>
</frameset>
</html>