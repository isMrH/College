<%@ page language="java" pageEncoding="UTF-8"%>

<html>
  <head>
    <title>小脚本测试</title>
  </head>
  
  <body>
  	<h1>JSP Scriptlet(小脚本)</h1>
    <table bgcolor="9999dd" border="1" width="300px">
	<%-- Java脚本，这些脚本会对HTML的标签产生作用 --%>
	<%-- 下面的循环将控制<tr>标签循环 --%>
	<%
		for(int i = 0 ; i < 10 ; i++){
	%>
		<tr>
			<td>循环值:</td>
			<td><%out.print(i); %></td>
		</tr>
	<%
		}
	%>
	</table>
  </body>
</html>
