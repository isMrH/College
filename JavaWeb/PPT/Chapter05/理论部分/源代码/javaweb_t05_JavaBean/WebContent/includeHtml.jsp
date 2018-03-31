<%@ page language="java" contentType="text/html; charset=gb2312"
	pageEncoding="gb2312"%>
<%-- <%@ include file="welcome.html" %> --%>
<html>
<head>
	<title>使用 include 动作</title>
</head>
<body>
	<jsp:include page="welcome.html" flush="true"></jsp:include>
	<%-- <jsp:include page="welcome1.jsp" flush="true">
		<jsp:param name="username" value="jack" />
	</jsp:include> --%>
	此文本将在显示完<b>welcome.jsp</b>的内容后显示
</body>
</html>
