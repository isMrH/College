<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>
<jsp:useBean id="bo" class="com.systop.JavaBean.BookOperate"></jsp:useBean>
<jsp:useBean id="book" class="com.systop.JavaBean.BookBean"></jsp:useBean>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

<%
	//设置request 和 response 的字符编码格式
	request.setCharacterEncoding("UTF-8");
	response.setCharacterEncoding("UTF-8");
	//获得下拉列表选项的值
	String types=request.getParameter("selectCon");
	//获取文本框输入的值
	String names=request.getParameter("entersName");
	Collection col=new ArrayList();
	if(types!=null && types.trim().length()!=0){
		int id=Integer.parseInt(names);
		book=bo.getBookByID(id);
		if(book.getBookID()>0){
			col.add(book);
		}		
	}else if(types.equals("subject")){
		col=bo.getBooksByBookName(names);
	}else if(types.equals("all")){
		col=bo.getAllBook();
	}
	request.setAttribute("bookarray",col);
	request.getRequestDispatcher("/result.jsp").forward(request,response);
%>
</body>
</html>