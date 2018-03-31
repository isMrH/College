<%@ page language="java" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Type" %>
<%@ page import="cn.com.systop.jspt06.dao.TypeDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.TypeDAOImpl" %>
<%
	//设置request编码的字符集方式，简体中文使用UTF-8字符集
    request.setCharacterEncoding("UTF-8");
	//下面获取表单元素的值,封装到type实体类对象中
	String typeName = request.getParameter("typeName");
	Type type = new Type();
	type.setTypeName(typeName);
	//创建电影分类数据库访问类对象
  	TypeDAO typeDAO = new TypeDAOImpl();
  	//调用电影分类添加方法
	int row = typeDAO.save(type);
	//根据返回结果判断是否添加成功
	if(row > 0){
		//添加成功转发到成功页面success.jsp
		request.getRequestDispatcher("/admin/success.jsp").forward(request,response);
	}else{
		//添加失败转发到失败页面error.jsp
		request.getRequestDispatcher("/admin/error.jsp").forward(request,response);
	}
%>
