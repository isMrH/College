<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		
		if(session.getAttribute("user")==null){
			response.sendRedirect("login.html");
		}else{
			out.print(session.getAttribute("user"));
		}
		//如果请求跳转到jsp页面，可以添加代码进行验证，
		//如果请求条传到静态页面，如何添加代码验证？
		//此时可以使用过滤器实现。
		//添加AuthenticationFilter实现效果
	%>
</body>
</html>