<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<%
	String []CH= {"红色","绿色","蓝色","黄色","黑色","粉色"};
	String []EN = {"Red","Green","Blue","Yellow","Black","Pink"};	
%>
<table>
<%
	for(int i=0;i<6;i++){	
		out.print("<tr bgcolor="+EN[i]+">");
		out.print("<td>"+CH[i]+"</td>");
		out.print("<td>"+CH[i]+"</td>");
		out.print("<td>"+CH[i]+"</td>");
		out.print("</tr>");
	}
%>
</table>
</body>
</html>