<%@ page language="java" contentType="text/html; charset=GB2312"
	pageEncoding="GB2312" %>
<%@page import="java.util.Vector"%>
<%@page import="cn.com.systop.l08.listener.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
	"http://www.w3.org/TR/html4/loose.dtd">
<html>
	<head>
		<meta http-equiv="Content-Type" 
			content="text/html; charset=GB2312">
		<title>��ҳ</title>
	</head>
<body>
	<%
	//���δ��¼��ת���¼ҳ��
	if(session.getAttribute("userName")==null){
		response.sendRedirect("login.jsp");
	}
	Vector onlineUsers=UserList.getVector(); //��ȡ�洢�����û�����vector����
%>
<center>
	<br/><br/>
	<h2>��¼�ɹ�</h2>
	<hr/>
	<br/>
		��ӭ�� <span style="color:red;">
		<%=session.getAttribute("userName") %>
		</span> &nbsp;&nbsp;&nbsp;&nbsp;
	<a href="exitdo">�˳���¼</a>
	<br/><br/>
	��ǰ����������<span style="color:red;">
		<%=UserList.getUserCount() %>��</span>
	<br/><br>
	�����û����� :
	<br/>	
	<select multiple="multiple" name="list"
		style="width:200px;height:250px">
	<%	
		for(int i=0;i<onlineUsers.size();i++){
			out.write("<option>"+onlineUsers.get(i)+"</option>");
		}
	%>
	</select>
</center>
</body>
</html>
