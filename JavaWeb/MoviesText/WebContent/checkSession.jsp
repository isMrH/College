<%@ page import="com.systop.*" pageEncoding="UTF-8"%>

<%
	//如果会话中不存在该用户的登录信息，跳转到登录页面
	Users user = (Users) session.getAttribute("LOGINED_USER");
	if (user == null) {
		response.sendRedirect(request.getContextPath() + "/login.jsp");
	}
%>


