<%@ page contentType="text/html; charset = gb2312" language = "java" %>
<jsp:useBean id = "userregisterbean" 
	class = "systop.register.UserRegisterBean" scope = "request"/>
<jsp:setProperty name = "userregisterbean" property = "*"/>
<html>
	<head>
		<meta http-equiv = "Content-Type" 
		content = "text/html; charse t= gb2312" />
	<title>зЂВсбщжЄ</title>
	</head>
	<body>
		<%
			if(userregisterbean.validaty()){
		%>
				<jsp:forward page = "register_success.jsp" />
		<%
			}else{
		%>
				<jsp:forward page = "register_failure.jsp" />
		<%
			}
		%>
	</body>
</html>
