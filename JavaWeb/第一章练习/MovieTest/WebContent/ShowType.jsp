<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ page import="com.MySql" %>
<%@ page import="com.Type" %> 
<%@ page import="java.util.*"%>
<%@ page import="java.util.Vector" %>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>小型电影DVD在线销售系统</title>
</head>
<body>
    <%--此处添加jsp脚本 --%>
    <%
       //创建电影分类数据库访问类对象
       MySql ms = new MySql();
       //查询电影分类列表
       List list = new ArrayList();
       list = ms.search();
       for(int i=0;i<list.size();i++){
    	   Type type = (Type)list.get(i);
    %>
           <img src="images/arr.gif">&nbsp;
           <a href="#" class="menu"><%=type.getTypeName() %></a><br><br>
     <%
       }
     %>
</body>
</html>