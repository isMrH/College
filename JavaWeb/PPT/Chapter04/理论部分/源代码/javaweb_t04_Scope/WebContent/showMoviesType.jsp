<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Type" %>
<%@ page import="cn.com.systop.jspt06.dao.TypeDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.TypeDAOImpl" %>

<html>
  <head>
    <title>小型电影DVD在线销售系统</title>
  </head>
  
  <body>
    <%-- 此处添加JSP脚本 --%>
	<% 
		TypeDAO typeDAO = new TypeDAOImpl();//创建电影分类数据库访问类对象
		List list = typeDAO.search();//查询电影分类列表
		//循环遍历电影分类列表在页面显示
		for(int i=0; i<list.size(); i++) {
			Type type = (Type)list.get(i);
	%>	
			<img src="images/arr.gif">&nbsp; 
			<a href="index.jsp?typeID=<%=type.getTypeID() %>" class="menu"><%=type.getTypeName() %></a><br><br>
	<% 
		}
	%>
  </body>
</html>
