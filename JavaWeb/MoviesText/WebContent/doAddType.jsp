<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.systop.*"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	//设置字符集编码
	request.setCharacterEncoding("UTF-8");
	String typeName=request.getParameter("typeName");
	Type type=new Type();
	type.setTypeName(typeName);
	TypeDao td=new TypeDao();
	int row=td.savaType(type);
	if (row>0){
		request.getRequestDispatcher("success.jsp").forward(request,response);
	}
	else{
		request.getRequestDispatcher("error.jsp").forward(request,response);
	}
%>
</body>
</html>