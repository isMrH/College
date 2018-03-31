<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8" 
    import="java.util.*,cn.com.systop.javabean.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<jsp:useBean id="ManageMes" class="cn.com.systop.oper.ManageMes" scope="page"></jsp:useBean>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		Collection col=(Collection) request.getAttribute("message");
		Iterator it=col.iterator();
		while(it.hasNext()){
			MessageBean message=(MessageBean)it.next();
	
	%>
	<table width="50%" border="1">
		<tr>
			<td width="29%" height="42" bgcolor="#99cc66">
				<span class="style2">
					主题：
				</span>
			</td>
			<td width="71%">
				<%=message.getTitle() %>
			</td>
		</tr>
		
		<tr>
			<td height="53" bgcolor="#99cc66">
				<span class="style2">
					留言人：
				</span>
			</td>
			<td>
				<%=message.getMessName() %>
			</td>
		</tr>
		<tr>
			<td height="45" bgcolor="#99cc66">
				<span class="style2">
					留言时间：
				</span>
			</td>
			<td>
				<%=message.getMessDate().toLocaleString() %>
			</td>
		</tr>
		<tr>
			<td height="53" bgcolor="#99cc66">
				<span class="style2">
					留言内容：
				</span>
			</td>
			<td>
				<%=message.getContent() %>
			</td>
		</tr>
		</table>
		
<%
	}
%>
</body>
</html>
