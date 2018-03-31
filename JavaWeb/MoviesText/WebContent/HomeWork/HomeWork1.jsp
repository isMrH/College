<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<%!
	int[] years=new int[]{1500,1900,2000,2005,2008,2010};
	public String Year(int year){
		String msg="";
		if (year%4==0 && year%100!=0 || year%400==0){
			msg="闰年";
		}
		else{
			msg="平年";
		}
		return msg;
	}
%>
<table border="1px;" align="center">
	<tr>
		<td>年份</td>
		<td>闰年还是平年</td>
	</tr>
	<%
		for(int i=0;i<years.length;i++){
			out.print("<tr>");
			out.print("<td>"+years[i]+"</td>");
			out.print("<td>"+Year(years[i])+"</td>");
			out.print("</tr>");
		}
	%>
</table>
</body>
</html>