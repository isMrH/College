<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.lang.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%!
	String[] strings=new String[]{"SEES","SOS","ABC","ABCD","LOVEVOL"};
	public String substringstr(String sql){
		String msg="";
		StringBuffer stringBuffer=new StringBuffer(sql);
		if (stringBuffer.reverse().toString().equals(sql)){
			msg="是";
		}
		else{
			msg="否";
		}
		return msg;
	}
%>
<table border="1px;" align="center">
	<tr>
		<td>字符串</td>
		<td>是否回文字符串</td>
	</tr>
	<%
		for(int i=0;i<strings.length;i++){
			out.print("<tr>");
			out.print("<td>"+strings[i]+"</td>");
			out.print("<td>"+substringstr(strings[i])+"</td>");
			out.print("</tr>");
		}
	%>
</body>
</html>