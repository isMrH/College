<%@ page contentType="text/html;charset=GB2312"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
	<head>
		<title>JSTL c:outʾ��</title>
	</head>
	<body>		
		<c:out value="Hello JSP 2.0 !! " /> <br/>
		<c:out value="${3 + 5}" /> <br/>
		<c:out value="${param.data}" default="No Data" /> <br/>
		<c:out value="${param.data}" >no data</c:out> <br/>
		<c:out value="<B>�������ַ�</B>" escapeXml="true"/> <br/>
		<c:out value="<B>�������ַ�</B>" escapeXml="false" /> 
	</body>
</html>
