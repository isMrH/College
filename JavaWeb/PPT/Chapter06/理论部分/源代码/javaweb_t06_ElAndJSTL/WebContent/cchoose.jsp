<%@ page contentType="text/html;charset=GB2312"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
<head>
<title>c:if</title>
</head>
<body>
<c:set var="i" value="18"/>
<c:choose>
	<c:when test="${i<18}">
		����
	</c:when>
	<c:when test="${i>18&&i<=30}">
		����
	</c:when>
	<c:when test="${i>30&&i<=50}">
		����
	</c:when>
	<c:otherwise>
		����
	</c:otherwise>
</c:choose>
</body>
</html>
