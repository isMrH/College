<%@ page language="java" contentType="text/html; charset=gb2312"
	pageEncoding="gb2312"%>
<jsp:useBean id="userRegister"
	class="cn.com.systop.t02.UserRegisterBean" scope="request"></jsp:useBean>
<html>
<head>
<title>注册</title>
</head>
<body>
<form action="register.jsp" method="post">
<table>
	<tr>
		<td colspan="2">
		<h3>请您注册</h3>
		</td>
	</tr>
	<tr>
		<td>注册名：</td>
		<td><input type="text" name="userName"></td>
	</tr>
	<tr>
		<td>密&nbsp;&nbsp;码：</td>
		<td><input type="password" name="userPassword"></td>
	</tr>
	<tr>
		<td colspan="2"><input type="submit" value="注册"> <input
			type="reset" value="重置"></td>
	</tr>
</table>
</form>
<%
	request.setCharacterEncoding("gb2312");
%>
<jsp:setProperty name="userRegister" property="*"/>
<%
	if (userRegister.getUserName() != null) {
%>
		注册成功！<br>
		用户名：<jsp:getProperty name="userRegister"  property="userName"/><br>
		密码：<jsp:getProperty name="userRegister"  property="userPassword"/>
<%
	}
%>
</body>
</html>