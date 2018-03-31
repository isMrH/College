<%@ page language="java" pageEncoding="UTF-8"%>
<%
	String path = request.getContextPath();
	String basePath = request.getScheme() + "://"
			+ request.getServerName() + ":" + request.getServerPort()
			+ path + "/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<base href="<%=basePath%>">

		<title>收集参数的表单页</title>

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
		<FORM id="myForm" METHOD="post" ACTION="doPost.jsp">
			用户名：<INPUT TYPE="text" NAME="name">
			<hr>
			性别：<br>
			<INPUT TYPE="radio" NAME="gender" value="男">男
			<INPUT TYPE="radio" NAME="gender" value="女">女
			<hr>
			喜欢的颜色：<br>
			<INPUT TYPE="checkbox" NAME="color" value="红">红
			<INPUT TYPE="checkbox" NAME="color" value="绿">绿
			<INPUT TYPE="checkbox" NAME="color" value="蓝">蓝
			<hr>
			来自的国家：<br>
			<SELECT NAME="country">
				<option value="中国">中国</option>
				<option value="美国">美国</option>
				<option value="俄罗斯">俄罗斯</option>
			</SELECT>
			<hr>
			<INPUT TYPE="submit" value="提交">
			<INPUT TYPE="reset" value="重置">
		</FORM>
	</body>
</html>
