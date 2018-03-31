<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("utf-8");
	String name = request.getParameter("UserName");
	//name=new String(name.getBytes("iso-8859-1"),"utf-8");
	out.print("Hello," + name);
%>