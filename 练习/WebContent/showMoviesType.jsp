<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.system.*" %>
<%@ page import="java.util.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%--此处添加jsp脚本 --%>
<%-- --%>
<% 
   //创建电影分类数据库访问类对象
   Typeinfo typeinfo=new Typeinfo();
   //创建电影分类列表
   List list=typeinfo.find();
   //遍历电影分类列表在页面
   for(int i=0;i<list.size();i++){
	   Type type=(Type)list.get(i);
	  // out.print("<img src='images/arr.gif'>");
	  // out.print("<a href='#' class='menu'>"+type.getTypename()+"</a>");
   %>
      <img src="images/arr.gif">
      <a href='#' class='menu'><%=type.getTypename()%></a><br/><br/>
   <%} %>
 

</body>
</html>