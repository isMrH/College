<%@ page contentType="text/html; charset=gb2312" language="java" %>
<jsp:useBean id = "userregisterbean" 
	class = "systop.register.UserRegisterBean" scope = "request"/>
<html>
<head>
	<meta http-equiv = "Content-Type" 
		content = "text/html; charset = gb2312" />
	<title>ע��ɹ�</title>
</head>
<body>
	<center>
	<h1>ף����ע��ɹ���</h1>
	<hr>
	<table>
		<tr>
			<td colspan="2"><h3>���ס����ע����Ϣ</h3></td>
		</tr>
		<tr>
			<td>ע������</td>
			<td>
				<jsp:getProperty name = "userregisterbean"
					property = "username"/>
			</td>
		</tr>
		<tr>
			<td>��&nbsp;&nbsp;�룺</td>
			<td>
				<jsp:getProperty name = "userregisterbean" 
					property = "userpassword"/>
			</td>
		</tr>
	</table>
</center>
</body>
</html>
