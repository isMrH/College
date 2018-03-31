<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	
	session id:<%=session.getId()%><br/>
	<c:if test="${empty sessionScope.SelectedGoods }">
		<h1>未购买任何商品：</h1>
	</c:if>
	<c:if test="${!empty sessionScope.SelectedGoods }">
	购物车中有以下商品：<br />
		<c:set scope="page" var="total" value="0"></c:set>
		<ul>
			<c:forEach items="${sessionScope.SelectedGoods}" var="good">
				<c:if test="${good.key=='1'}">
					<li>商品名称：《JSP从入门到精通》,购买数量为：${good.value
						}，金额为：${good.value*34.5}</li>
					<c:set var="total" value="${total+good.value*34.5}" />
				</c:if>
				<c:if test="${good.key=='2' }">
					<li>商品名称：小霸王游戏机,购买数量为：${good.value }，金额为：${good.value*345}</li>
					<c:set var="total" value="${total+good.value*345}" />
				</c:if>
			</c:forEach>
		</ul>
		<h1>总金额为：${total }</h1>
	</c:if>
</body>
</html>