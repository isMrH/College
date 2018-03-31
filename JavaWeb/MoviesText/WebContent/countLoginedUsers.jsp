<%@ page language="java" pageEncoding="GBK"%>
<%@ page import="com.systop.*"%>
<%@ page import="java.util.*"%>
<html>
<%
	List loginedUsers = new ArrayList(); //访问者列表
	//从全局范围内取出访问者列表
	if (application.getAttribute("LOGINED_USER") != null) {
		loginedUsers = (List) application.getAttribute("LOGINED_USER");
	}
%>
<body>
<p align="center"><br><br><br>
已经有<%=loginedUsers.size()%>人访问过本网站!<br><br>
他们是：<br>
<%
		for (int i = 0; i < loginedUsers.size(); i++) {
		Users loginedUser = (Users) loginedUsers.get(i);
		out.print(loginedUser.getUserName());
		out.print("<br/>");
	}
%> 
</p>
</body>
</html>
