<%@ page language="java" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>a.jsp</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body>
    <form action="b.jsp" method="post">
    	请选择您喜欢的运动：<br>
    	<input type="checkbox" name="like" value="basketball">basketball
    	<input type="checkbox" name="like" value="football">football
    	<input type="checkbox" name="like" value="pingpong">pingpong
    	<input type="checkbox" name="like" value="golf">golf
    	<br>
    	<input type="submit" value="提交">
    </form>
  </body>
</html>
