<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Insert title here</title>
</head>
<body>
<table border="1px" bgcolor="" width="250px">
<%!
    String[] cin={"红色","绿色","蓝色","黄色","灰色","粉色"};
    String[] color={"red","green","blue","yellow","gray","pink"};
%>
<%
    for(int i=0;i<cin.length;i++){
    	out.print("<tr align='center' bgcolor="+color[i]+">");
    	out.print("<td>"+cin[i]+"</td>");
    	out.print("<td>"+cin[i]+"</td>");
    	out.print("<td>"+cin[i]+"</td>");
    	out.print("</tr>");
    }
%>
</table>
</body>
</html>