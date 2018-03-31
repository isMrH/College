<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<style type="text/css"> 
	*{
	margin:0px;
	padding:0px;
	}
	#Wapper{
	margin:auto 0px;
	width:500px;
	border:1px solid #CCC;
	}
	.Title{
	height:40px;
	background-color:red;
	}
	.Mes{
	float:left;
	}
	.Mes li{
	height:20px;

	width:40px;
	}
	.input{
	float:left;

	}
	.input li{
	height:20px;

	width:100px;
	}
</style>
</head>
<body>

	<div id="Wapper">		
		<div class="Title">
			<h3>会员基本信息</h3>
		</div>
		<div class="Main">
			<ul class="Mes">
				<li>姓名</li>
			</ul>
			<ul class="input">
				<li><input type="text" /></li>
			</ul>
		</div>
	</div>

</body>
</html>