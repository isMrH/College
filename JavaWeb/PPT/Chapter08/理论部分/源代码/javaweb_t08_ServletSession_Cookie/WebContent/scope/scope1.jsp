<%@ page language="java" pageEncoding="UTF-8"%>
<%
	// pageContext作用域中的变量进行累加
	Integer countPage = (Integer) pageContext.getAttribute("countPage");
	if (countPage == null) {
	    pageContext.setAttribute("countPage", 1);
	} else {
	    pageContext.setAttribute("countPage", countPage + 1);
	} 
	// request作用域中的变量进行累加
	Integer countRequest = (Integer) request.getAttribute("countRequest");
	if (countRequest == null) {
	    request.setAttribute("countRequest", 1);
	} else {
	    request.setAttribute("countRequest", countRequest + 1);
	}
	// session作用域中的变量进行累加
	Integer countSession = (Integer) session.getAttribute("countSession");
	if (countSession == null) {
	    session.setAttribute("countSession", 1);
	} else {
	    session.setAttribute("countSession", countSession + 1);
	}
	// application作用域中的变量进行累加
	Integer countApplication = (Integer) application.getAttribute("countApplication");
	if (countApplication == null) {
	    application.setAttribute("countApplication", 1);
	} else {
	    application.setAttribute("countApplication", countApplication + 1);
	}
	// 执行forward转发到scope2.jsp
	request.getRequestDispatcher("scope2.jsp").forward(request,response);
%>