<%@ page contentType="text/html;charset=GB2312"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html>
<head>
<title>c:catch</title>
</head>
<body>
<c:catch var="error_Message">
<%
  String eFormat="not number";
  int i=Integer.parseInt(eFormat);
%>
</c:catch>
${error_Message}
hello.
</body>
</html>
