<%@ page language="java" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>登录页面</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<link rel="stylesheet" type="text/css" href="<%=path%>/CSS/styles.css">
	<script type="text/javascript">
		function doLogin(){
			var usr  = document.getElementById("usr");
			var pwd  = document.getElementById("pwd");
			if (usr.value==""){
				alert("用户名不能为空");
				usr.focus();
				return ;
			}
			if (pwd.value==""){
				alert("密码不能为空");
				pwd.focus();
				return ;
			}
			document.forms[0].submit();
		}
	</script>
  </head>
  
  <body>
  	<h2>小型电影DVD在线销售系统后台管理登录页面</h2>
    <div id="dvLogin">
		<form action="<%=path%>/doLogin.jsp" method="post">
			用户名：<input type="text" name="userName" id="usr" style="width:60px;" /> <br/>
			密&nbsp;&nbsp;&nbsp;&nbsp;码：<input type="password" name="passWord" id="pwd" style="width:60px;" /> 
			<br />
			<a href="<%=path%>/userInfo.jsp" class="a_button">用户注册</a>&nbsp;
			<button class="button" onclick="javascript:doLogin();" style="width:40px;">登录</button> <br />  
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<img src="images/login.gif" style="width:75px;"></img>
		</form>
	</div>
  </body>
</html>
