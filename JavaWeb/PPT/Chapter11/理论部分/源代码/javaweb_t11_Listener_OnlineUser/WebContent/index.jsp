<%@ page language="java" contentType="text/html; charset=GB2312"
	pageEncoding="GB2312" %>
<%@page import="java.util.Vector"%>
<%@page import="cn.com.systop.l08.listener.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
	"http://www.w3.org/TR/html4/loose.dtd">
<html>
	<head>
		<meta http-equiv="Content-Type" 
			content="text/html; charset=GB2312">
		<title>首页</title>
	</head>
<body>
	<%
	//如果未登录，转向登录页面
	if(session.getAttribute("userName")==null){
		response.sendRedirect("login.jsp");
	}
	Vector onlineUsers=UserList.getVector(); //获取存储在线用户名的vector对象
%>
<center>
	<br/><br/>
	<h2>登录成功</h2>
	<hr/>
	<br/>
		欢迎你 <span style="color:red;">
		<%=session.getAttribute("userName") %>
		</span> &nbsp;&nbsp;&nbsp;&nbsp;
	<a href="exitdo">退出登录</a>
	<br/><br/>
	当前在线人数：<span style="color:red;">
		<%=UserList.getUserCount() %>人</span>
	<br/><br>
	在线用户名单 :
	<br/>	
	<select multiple="multiple" name="list"
		style="width:200px;height:250px">
	<%	
		for(int i=0;i<onlineUsers.size();i++){
			out.write("<option>"+onlineUsers.get(i)+"</option>");
		}
	%>
	</select>
</center>
</body>
</html>
