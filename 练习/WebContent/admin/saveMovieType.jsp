<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.system.* "%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<%
	//设置request编码的字符集方式，简体中文使用UTF-8	字符集
	request.setCharacterEncoding("UTF-8");
	//下面获取表单元素的值封装到Type实体类对象中
	String typeName=request.getParameter("typeName");
	Type type=new Type();
	type.setTypename(typeName);
	//创建电影分类数据访问类对象
	Typeinfo dao=new Typeinfo();
	//调用电影分类是否添加成功
	int row=dao.save(type);
	//根据返回结果判断是否添加成功
	if(row >0){
		request.getRequestDispatcher("success.jsp").forward(request,response);
	}else{
		request.getRequestDispatcher("error.jsp").forward(request,response);
	}

%>
</body>
</html>