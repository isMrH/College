<%@ page language="java" pageEncoding="UTF-8"%>
<%@ include file="checkSession.jsp"%>
<HTML>
<HEAD>
<link href="<%=request.getContextPath() %>/CSS/styles.css" rel="stylesheet" type="text/css">
</HEAD>
<BODY BGCOLOR="#E8EDEE">
<br><br>
<h3>小型电影DVD在线销售系统后台管理</h3>
<p>
<a href="movieType.jsp" target="mainFrame">电影分类信息发布</a><br>
<a href="movieInfo.jsp" target="mainFrame">电影DVD信息发布</a>
<br><br>
<a href="countLoginedUsers.jsp" target="mainFrame">已访问人数统计</a>
<br><br>
<a href="<%=request.getContextPath() %>/index.jsp" target="blank">小型电影DVD在线销售系统前端</a>
</p>
</BODY>
</HTML>
