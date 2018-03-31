<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.dao.UsersDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.UsersDAOImpl" %>
<%@ page import="cn.com.systop.jspt06.entity.Users" %>
<%
	String path = request.getContextPath();
%>
<%
  	//设置request编码的字符集方式，简体中文使用UTF-8字符集 
	request.setCharacterEncoding("UTF-8"); 
	//下面依次获取表单元素的值 
	String userName = request.getParameter("userName"); 
	String passWord = request.getParameter("passWord"); 
	//进行登录验证 
	Users loginedUser = null;
	UsersDAO usersDAO = new UsersDAOImpl();
	loginedUser = usersDAO.doLogin(userName, passWord);
	if(loginedUser != null) {//如果是已注册用户
		//在会话中存放已登录用户信息
		session.setAttribute("LOGINED_USER",loginedUser);
		List loginedUsers = new ArrayList(); //已访问用户列表
		//从全局范围内取出原有的已访问用户列表
		if (application.getAttribute("LOGINED_USER") != null) {
			loginedUsers = (List) application.getAttribute("LOGINED_USER");
		}
		//把新登录用户的信息存入已访问用户列表中
		loginedUsers.add(loginedUser);
		//在全局范围内存入已访问用户列表
		application.setAttribute("LOGINED_USER", loginedUsers);	
		//重定向到后台管理首页,绝对路径
		response.sendRedirect(path + "/admin/admin.jsp"); 
	} else { 
		//重定向回后台管理登录页面,绝对路径
		response.sendRedirect(path + "/admin/login.jsp");
	} 
%>