<%@page import="cn.com.ambow.bean.Dog"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<jsp:useBean id="person" class="cn.com.ambow.bean.Person"></jsp:useBean>
	
	姓名：<jsp:getProperty property="name" name="person" /><br> 
	年龄：<jsp:getProperty property="age" name="person" /><br> 
	宠物：<jsp:getProperty property="dog" name="person" /><br>
	
	<%--说明访问成员时会报错。 --%>
	<%-- <jsp:getProperty
		property="dog.getName" name="person" /> --%>
	<%--
		//或者使用以下方法（不能实现标记和代码的分离）：
		Dog dog = person.getDog();
		out.print(dog.getName());
	--%>
	<%--使用EL表达式可以修正以上问题 --%>
	
</body>
</html>