<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>
<%@ page import="com.systop.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	//创建电影分类数据库访问类对象
	TypeDao td=new TypeDao();
	//查询电影分类列表
	List ve=td.getType();
	//显示
	for(int i=0;i<ve.size();i++){
		Type type=(Type)ve.get(i);
	%>
	<img src="images/arr.gif">&nbsp;
	<a href="index.jsp?typeID=<%=type.getTypeID() %>" class="menu"><%=type.getTypeName() %></a><br/><br/>
	<%
		}
	%>
</body>
</html>