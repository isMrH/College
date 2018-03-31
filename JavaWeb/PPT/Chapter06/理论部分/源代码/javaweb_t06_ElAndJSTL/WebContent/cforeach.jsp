<%@ page contentType="text/html;charset=GB2312"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
<head>
<title>c:forEach</title>
</head>
<body>
<table>
	<tr>
		<th>�к�</th>
		<th>��ֵ</th>
		<th>ƽ��</th>
	</tr>
	<c:forEach var="x" begin="0" end="10" step="2" varStatus="status">
		<tr>
			<td><c:out value="${status.count}" /></td>
			<td><c:out value="${x}" /></td>
			<td><c:out value="${x * x}" /></td>
		</tr>
	</c:forEach>
</table>
</body>
</html>
