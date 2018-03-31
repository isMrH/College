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
		少年
	</c:when>
	<c:when test="${i>18&&i<=30}">
		青年
	</c:when>
	<c:when test="${i>30&&i<=50}">
		中年
	</c:when>
	<c:otherwise>
		老年
	</c:otherwise>
</c:choose>
</body>
</html>
