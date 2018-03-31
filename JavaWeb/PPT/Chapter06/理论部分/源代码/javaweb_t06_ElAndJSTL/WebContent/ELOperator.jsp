<%@page contentType="text/html;charset=gb2312"%>
<html>
<head>
<title>ELOperator.jsp</title>
</head>
<body>
<%
	String username = "mike";
	request.setAttribute("username", username);
%>
<table width="75%" border="1" align="left">
	<tr>
		<th>ÔËËã·û</th>
		<th>½á¹û</th>
	</tr>
	<tr>
		<td>14£«3</td>
		<td>${14+3}</td>
	</tr>
	<tr>
		<td>14-3</td>
		<td>${14-3}</td>
	</tr>
	<tr>
		<td>14*3</td>
		<td>${14*3}</td>
	</tr>
	<tr>
		<td>14/3</td>
		<td>${14/3}</td>
	</tr>
	<tr>
		<td>14%3</td>
		<td>${14%3}</td>
	</tr>
	<tr>
		<td>14==3</td>
		<td>${14==3}</td>
	</tr>
	<tr>
		<td>14 != 3</td>
		<td>${14!=3}</td>
	</tr>
	<tr>
		<td>14 < 3</td>
		<td>${14 < 3}</td>
	</tr>
	<tr>
		<td>14 > 3</td>
		<td>${14 > 3}</td>
	</tr>
	<tr>
		<td>14 <=3</td>
		<td>${14 <=3}</td>
	</tr>
	<tr>
		<td>14 >=3</td>
		<td>${14 >=3}</td>
	</tr>
	<tr>
		<td>true && false</td>
		<td>${true && false}</td>
	</tr>
	<tr>
		<td>true || false</td>
		<td>${true || false}</td>
	</tr>
	<tr>
		<td>! false</td>
		<td>${! false}</td>
	</tr>
	<tr>
		<td>empty username</td>
		<td>${empty username}</td>
	</tr>
	<tr>
		<td>empty password</td>
		<td>${empty password}</td>
	</tr>
</table>
</body>
</html>
