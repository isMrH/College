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

		<title>获取请求参数</title>

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
		<%
			/*此例演示修改tomcat安装目录下的conf目录中的server.xml文件后get方式提交的效果，
				修改server.xml文件后不用写任何设置字符编码的代码
			*/
			//下面依次获取表单元素的值
			String name = request.getParameter("name");
			String gender = request.getParameter("gender");
			String country = request.getParameter("country");
			//如果某个请求参数有多个值，将使用getParameterValues方法获取多个值的数组
			String[] color = request.getParameterValues("color");
		%>
		<%-- 下面依次输出表单元素的值 --%>
		您的名字：<%=name%><hr>
		您的性别：<%=gender%><hr>
		<%-- 循环输出获取的复选框数组值 --%>
		您喜欢的颜色：
		<%
			for (int i=0; i<color.length; i++) {
			    out.println(color[i] + " ");
			}
		%><hr>
		您来自的国家：	<%=country%><hr>
	</body>
</html>
