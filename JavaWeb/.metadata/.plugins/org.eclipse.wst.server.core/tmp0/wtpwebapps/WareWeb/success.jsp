<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8" import="java.util.*,cn.com.systop.JavaBean.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<style type="text/css">
*{
margin:0px;
padding:0px;
}
#Wapper{
width:1000px;
margin:0px auto;
height:auto;
}
#Main{
width:500px;
height:auto;
margin:0px auto;
}
.Title{
font-size:24px;
font-width:blod;
padding-left:20px;
margin-bottom:20px;
}
</style>
</head>
<body>
	<%
		Collection col=(Collection) request.getAttribute("WareBean");
		Iterator it=col.iterator();
		while(it.hasNext()){
			WareBean wb=(WareBean)it.next();
	
	%>
<div id="Wapper">
	<div id="Main">
		<div class="Title">添加库存成功</div>
		<div>商品名称：<%=wb.getWareName()%></div>
		<div>新增库存：<%=wb.getWareSort()%></div>
		<div>现共有库存为：<%=wb.getWareAmount()%></div>
		<div><a href="AddWare.jsp">返回上一页</a></div>
	</div>
</div>
<%
	}
%>
</body>
</html>