<%@ page language="java" contentType="text/html; charset=gb2312"
	pageEncoding="gb2312"%>
<jsp:useBean id="userRegister"
	class="cn.com.systop.t02.UserRegisterBean" scope="request"></jsp:useBean>
<html>
<head>
<title>ע��</title>
</head>
<body>
<form action="register.jsp" method="post">
<table>
	<tr>
		<td colspan="2">
		<h3>����ע��</h3>
		</td>
	</tr>
	<tr>
		<td>ע������</td>
		<td><input type="text" name="userName"></td>
	</tr>
	<tr>
		<td>��&nbsp;&nbsp;�룺</td>
		<td><input type="password" name="userPassword"></td>
	</tr>
	<tr>
		<td colspan="2"><input type="submit" value="ע��"> <input
			type="reset" value="����"></td>
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
		ע��ɹ���<br>
		�û�����<jsp:getProperty name="userRegister"  property="userName"/><br>
		���룺<jsp:getProperty name="userRegister"  property="userPassword"/>
<%
	}
%>
</body>
</html>