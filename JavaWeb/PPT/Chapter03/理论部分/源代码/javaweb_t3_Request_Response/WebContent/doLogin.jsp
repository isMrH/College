<%@ page language="java" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
System.out.println("path：" + path);
System.out.println("basePath：" + basePath);
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>登录验证</title>
    
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
    	//设置request编码的字符集方式，简体中文使用UTF-8字符集
		request.setCharacterEncoding("UTF-8");
		//下面依次获取表单元素的值
		String userName = request.getParameter("userName");
		String passWord = request.getParameter("passWord");
		//进行登录验证
		if("admin".equals(userName) && "admin".equals(passWord)) {
			response.sendRedirect("welcome.jsp");//重定向到欢迎页面,相对路径
			//response.sendRedirect(path + "/welcome.jsp");//重定向到欢迎页面,绝对路径
			//request.getRequestDispatcher("/welcome.jsp").forward(request,response);//转发到欢迎页面
		} else {
			response.sendRedirect("login.jsp");//重定向回登录页面,相对路径
			//response.sendRedirect(path + "/login.jsp");//重定向回登录页面,绝对路径
			//request.getRequestDispatcher("/login.jsp").forward(request,response);//转发回登录页面
		}
     %>
  </body>
</html>
