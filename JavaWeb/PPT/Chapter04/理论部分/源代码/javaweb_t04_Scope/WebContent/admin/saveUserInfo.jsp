<%@ page language="java" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Users" %>
<%@ page import="cn.com.systop.jspt06.dao.UsersDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.UsersDAOImpl" %>
<%
	String path = request.getContextPath();
%>
<%
    //设置request编码的字符集方式，简体中文使用UTF-8字符集
	request.setCharacterEncoding("UTF-8");
	//下面获取表单元素的值,封装到Users实体类对象中
	Users user = new Users();
	user.setUserName(request.getParameter("userName"));
	user.setUserPass(request.getParameter("userPass"));
	user.setUserIDCode(request.getParameter("userIDCode"));
	user.setUserTel(request.getParameter("userTel"));
	user.setUserAddress(request.getParameter("userAddress"));
	user.setUserZip(request.getParameter("userZip"));
	//创建用户信息数据库访问类对象
  	UsersDAO usersDAO = new UsersDAOImpl();
  	//调用用户注册方法
	int row = usersDAO.save(user);
	//根据返回结果判断是否添加成功
	if(row > 0){
		//注册成功，重定向到首页
		response.sendRedirect(path + "/index.jsp");
	}else{
		//注册失败，重定向回注册页面
		response.sendRedirect(path + "/admin/userInfo.jsp");
	}
%>