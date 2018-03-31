<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.removeAttribute("msg");
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<style type="text/css">
	*{
	margin:0px;
	margin-top:5px;
	padding:0px;
	}
	#Wapper{
	width:1000px;
	height:auto;
	border:1px solid #CCC;
	margin:0px auto;

	}
	h2{
	margin-top:10px;
	height:35px;
	line-height:30px;
	border-bottom:1px solid #CCC;
	padding-left:10px;
	}
	.text{
	padding-left:20px;
	}
	.img,.btn{
	width:1000px;
	margin:0px auto;
	text-align:center;
	}
</style>
</head>
<body>
<div id="Wapper">
<form id="form" action="<%=path%>/admin/saveMovieType.jsp" method="post">
<h2>添加电影分类信息</h2>
<div>
	<div class="text">电影分类名称<input type="text" name="typeName" /></div>
	<div class="btn"><input type="submit" value="提交" /></div>
	<div class="img"><img alt="Movie" src="<%=path%>/images/title_pic.jpg" width="900px"></div>"
</div>

</form>
</div>
</body>
</html>