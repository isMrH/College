<%@ page language="java" import="java.util.*" pageEncoding="gb2312"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>登录成功</title>
</head>
<body>
<jsp:useBean id="loginUser" class="cn.com.systop.l07.javabean.UserBean" scope="request"></jsp:useBean>
<h1>欢迎 <jsp:getProperty name="loginUser" property="userName"/> 登录成功！</h1>
</body>
</html>