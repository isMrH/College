<%@ page contentType="text/html;charset=GB2312"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
<head>
<title>c:if</title>
</head>
<body>
<c:set var="age" value="18"/>
<c:if test="${age<18}">
����
</c:if>
<c:if test="${age>=18&&age<=30}">
����
</c:if>
<c:if test="${age>30&&age<=60}">
����
</c:if>
<c:if test="${age>60}">
����
</c:if>
</body>
</html>
