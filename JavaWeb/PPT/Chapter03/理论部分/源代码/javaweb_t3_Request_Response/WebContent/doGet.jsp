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
			//获取原始的请求参数值			
       		String name = request.getParameter("name");
       		String gender = request.getParameter("gender");
			String country = request.getParameter("country");
			/* //将请求参数值使用ISO-8859-1字符串分解成字节数组			
			byte[] nameBytes = name.getBytes("ISO-8859-1");
			byte[] genderBytes = gender.getBytes("ISO-8859-1");
			byte[] countryBytes = country.getBytes("ISO-8859-1");
			//将字节数组重新编码成字符串			
			name = new String(nameBytes,"UTF-8");
			gender = new String(genderBytes,"UTF-8");
			country = new String(countryBytes,"UTF-8"); */
			//如果某个请求参数有多个值，将使用getParameterValues方法获取多个值的数组
			String[] colors = request.getParameterValues("color");
		%>
		<%-- 下面依次输出表单元素的值 --%>
		您的名字：<%=name%><hr>
		您的性别：<%=gender%><hr>
		<%-- 循环输出获取的复选框数组值 --%>
		您喜欢的颜色：
		<%
			for (int i=0; i<colors.length; i++) {
				//将请求参数值使用ISO-8859-1字符串分解成字节数组			
				byte[] colorBytes = colors[i].getBytes("ISO-8859-1");
				//将字节数组重新编码成字符串			
				String color = new String(colorBytes,"UTF-8");
			    out.println(color + " ");
			}
		%><hr>
		您来自的国家：	<%=country%><hr>
	</body>
</html>
