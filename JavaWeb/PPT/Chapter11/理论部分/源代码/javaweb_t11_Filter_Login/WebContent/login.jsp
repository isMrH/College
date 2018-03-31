<%@ page language="java" import="java.util.*" pageEncoding="gb2312"%>
<html>
<head>
<title>登录</title>
<script type="text/javascript">
	function check(){
		var userName = document.loginform.userName.value;
		var userPWD = document.loginform.userPassword.value;
		if(userName == ""){
			alert("用户名不能为空！");
			return false;
		}
		if(userPWD == ""){
			alert("密码不能为空！");
			return false; 
		}
		return true;
	}
</script>
<style type="text/css">
td img {
	display: block;
}

.STYLE1 {
	font-size: 12px;
	color: #276388;
	font-weight: bold;
}

body {
	margin-top: 50px;
}

.STYLE3 {
	font-size: 12px;
	color: #276388;
	font-weight: bold;
	font-family: "??";
}
.STYLE4 {
	font-size: 12px;
	color: red;
	font-weight: bold;
}
</style>
</head>
<body bgcolor="#ffffff">
<form action="LoginServlet" method="post" name="loginform">
<table width="757" height="108" border="0" align="center"
	cellpadding="0" cellspacing="0">
	<tr>
		<td align="center">
		<table width="288" height="157" border="0" cellpadding="0"
			cellspacing="0">
			<tr>
				<td width="66" rowspan="4" align="right"><img
					src="images/dl_r2_c1.jpg" width="18" height="147" /></td>
				<td colspan="2"><img src="images/dl_r2_c2.jpg" width="253"
					height="43" /></td>
				<td width="17" rowspan="4"><img src="images/dl_r2_c7.jpg"
					width="17" height="147" /></td>
			</tr>
			<tr>
				<td width="99" height="46" align="right"><span class="STYLE3">用户名:</span></td>
				<td width="154" align="left"><input name="userName" type="text"
					size="15" /></td>
			</tr>
			<tr>
				<td align="right"><span class="STYLE3">密&nbsp;&nbsp;码:</span></td>
				<td align="left"><span class="STYLE1"> <input
					name="userPassword" type="password" size="15" /> </span></td>
			</tr>
			<tr>
				<td height="52" align="center"><input type="submit" value="登录" onclick="return check()" /></td>
				<td height="52" align="center"><input type="reset" value="重置" /></td>
			</tr>
		</table>
		</td>
	</tr>
</table>
<br/>
<p align="center"><span class="style4" >${errorip }</span></p>
	<jsp:useBean id="loginUser" class="cn.com.systop.l07.javabean.UserBean" scope="request"></jsp:useBean>
	<%
		if(loginUser.getError() != null){
			out.print("<script type=\"text/javascript\">alert(\"用户名或密码错误！\");</script>");
		}
	%>
</form>
</body>
</html>
