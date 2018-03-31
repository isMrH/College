<%@ page contentType="text/html; charset=gb2312" language="java"%>
<html>
<head>
<title>Param.jsp</title>
</head>
<body>
姓名：${param.username}
</br>
密码：${param.password}
</br>
性别：${param.sex}
</br>
兴趣：${paramValues.habbit[0]}、${paramValues.habbit[1]}
</body>
</html>
