<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>注册成功</title>
</head>
<body>
<h1>注册成功，信息如下</h1>
<hr>
用户名：${userinfo.username}<br>
密码： ${userinfo.pwd}<br>
性别：${userinfo.sex} <br>
国家： ${userinfo.country}<br>
爱好：${userinfo.likes}<br>
备注：${userinfo.remark}<br>
</body>
</html>