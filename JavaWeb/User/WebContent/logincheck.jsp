<%@ page language="java" contentType="text/html; gb2312"
    pageEncoding="gb2312"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>µÇÂ¼ÑéÖ¤</title>

</head>
<body>
<%
   request.setCharacterEncoding("UTF-8");
%>
<!-- µ÷ÓÃ UserBean -->
<jsp:useBean id="loginUser" class="com.systop.javabean.UserBean" scope="request"></jsp:useBean>
<!-- ¸øUserBean¸³Öµ-->
<jsp:setProperty name="loginUser" property="*" />
<!-- µÇÂ¼ÑéÖ¤ -->
<%
	if(loginUser.login()){
		%><jsp:forward page="success.jsp"></jsp:forward><%
	}else{
		%><jsp:forward page="login.jsp"></jsp:forward><%
	}	                     
%>
</body>
</html>