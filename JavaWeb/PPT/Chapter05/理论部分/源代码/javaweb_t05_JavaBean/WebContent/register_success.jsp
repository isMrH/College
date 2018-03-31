<%@ page contentType="text/html; charset=gb2312" language="java" %>
<jsp:useBean id = "userregisterbean" 
	class = "systop.register.UserRegisterBean" scope = "request"/>
<html>
<head>
	<meta http-equiv = "Content-Type" 
		content = "text/html; charset = gb2312" />
	<title>注册成功</title>
</head>
<body>
	<center>
	<h1>祝贺您注册成功！</h1>
	<hr>
	<table>
		<tr>
			<td colspan="2"><h3>请记住您的注册信息</h3></td>
		</tr>
		<tr>
			<td>注册名：</td>
			<td>
				<jsp:getProperty name = "userregisterbean"
					property = "username"/>
			</td>
		</tr>
		<tr>
			<td>密&nbsp;&nbsp;码：</td>
			<td>
				<jsp:getProperty name = "userregisterbean" 
					property = "userpassword"/>
			</td>
		</tr>
	</table>
</center>
</body>
</html>
