<%@ page language="java" import="java.util.*" pageEncoding="gb2312"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>��¼�ɹ�</title>
</head>
<body>
<jsp:useBean id="loginUser" class="cn.com.systop.l07.javabean.UserBean" scope="request"></jsp:useBean>
<h1>��ӭ <jsp:getProperty name="loginUser" property="userName"/> ��¼�ɹ���</h1>
</body>
</html>