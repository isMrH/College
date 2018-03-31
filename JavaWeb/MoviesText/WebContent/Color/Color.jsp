<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<table>
<%!
	String[] color1=new String[]{"red","green","blue","yellow","pink"};
	String[] color2=new String[]{"红色","绿色","蓝色","黄色","粉红色"};
%>
<%
	for(int i=0;i<color1.length;i++){
		out.print("<tr>");
		out.print("<td bgColor='"+color1[i]+"'>"+color2[i]+"</td>");
		out.print("<td bgColor='"+color1[i]+"'>"+color2[i]+"</td>");
		out.print("<td bgColor='"+color1[i]+"'>"+color2[i]+"</td>");
		out.print("</tr>");
	}
%>
</table>
</body>
</html>