<%@ page language="java" contentType="text/html; charset=gb2312"
	pageEncoding="gb2312"%>
<%-- <%@ include file="welcome.html" %> --%>
<html>
<head>
	<title>ʹ�� include ����</title>
</head>
<body>
	<jsp:include page="welcome.html" flush="true"></jsp:include>
	<%-- <jsp:include page="welcome1.jsp" flush="true">
		<jsp:param name="username" value="jack" />
	</jsp:include> --%>
	���ı�������ʾ��<b>welcome.jsp</b>�����ݺ���ʾ
</body>
</html>
