<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>登录</title>
<style type="text/css">
*{
	margin:0px;
	padding:0px;
}
#login{
	margin:0px auto;
	width:250px;
	height:200px;
}
.Un input{
	width:150px;
}
#login div{
	margin-top:8px;
}
.Pwd input{
	width:150px;
}
.Un,.Pwd{
	float:right;
}
.Btn{
	clear:both;
	text-align:center;
}
</style>
<script type="text/javascript">
	function check(){
		var userNmae=document.loginform.userName.value;
		var userPWD=document.loginform.userPassword.value;
		if(userName==""){
			alert("用户名不能为空！");
			return false;
			}
		if(userPWD==""){
			alert("密码不能为空！");
			return false;
			}
		return false;
		}

</script>
</head>
<body>
	<form action="logincheck.jsp" method="post" name="loginform">
	<div id="login">
	<div class="Un">用户名：<input name="userName" type="text" /></div>
	<div class="Pwd">密 码：<input name="userPassword" type="password" /></div>
	<div class="Btn"><input type="submit" value="登录" onclick="return check()"/></div>
	</div>
	</form>
	
	<jsp:useBean id="loginUser" class="com.systop.javabean.UserBean" scope="request"></jsp:useBean>
	<%
		if(loginUser.getError() !=null){
			out.print("<script type=\"text/javascript\">alert(\"用户名或密码错误！\");</script>");
		}
	%>
</body>
</html>