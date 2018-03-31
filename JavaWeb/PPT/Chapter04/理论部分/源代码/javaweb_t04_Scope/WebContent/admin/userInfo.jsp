<%@ page language="java" pageEncoding="UTF-8"%>

<%
	String path = request.getContextPath();
	String basePath = request.getScheme() + "://"
			+ request.getServerName() + ":" + request.getServerPort()
			+ path + "/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<base href="<%=basePath%>">
		<title>用户注册</title>
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<link rel="stylesheet" type="text/css" href="<%=path%>/CSS/styles.css" />
		<script src="<%=path%>/admin/validate.js"></script>
		<script>
  		function doSubmit(){
  			if (Validator.Validate(document.forms[0],3)) {
	  			document.forms[0].submit();
	  		}
		}
	  </script>
	</head>
	<body>
		<form action="<%=path%>/admin/saveUserInfo.jsp" method="post">
			<div id="main" class="center">
				<div id="context">
					<div class="c_title">用户注册</div>
					<div class="c_content">
						<ul style="color:red;list-style-type:circle;">
						</ul>
						<table border="0">
							<tr>
								<th>用户名</th>
								<td><input type="text" name="userName" /></td>
							</tr>
							<tr>
								<th>密码</th>
								<td><input type="password" name="userPass" /></td>
							</tr>
							<tr>
								<th>再输一遍密码</th>
								<td><input type="password" name="userPass2" /></td>
							</tr>
							<tr>
								<th>身份证号码</th>
								<td><input type="text" name="userIDCode" /></td>
							</tr>
							<tr>
								<th>电话</th>
								<td><input type="text" name="userTel" /></td>
							</tr>
							<tr>
								<th>地址</th>
								<td><input type="text" name="userAddress" /></td>
							</tr>
							<tr>
								<th>邮编</th>
								<td><input type="text" name="userZip" /></td>
							</tr>
						</table>
						<div class="button_bar">
							<button onclick="javascript:doSubmit();">&nbsp;&nbsp;&nbsp;提 交&nbsp;&nbsp;&nbsp;</button>
						</div>
						<div class="m_title">
							<img src="<%=path%>/images/title_pic.jpg" width="450" height="275">
						</div><%--end of m_title --%>
						<div class="c_foot">&nbsp;</div>
					</div><%--end of c_content --%>
					<div class="c_foot">&nbsp;</div>
				</div><%--end of context --%>
			</div><%--end of main --%>
			<script>
			  	build_validate("userName","用户名必须在1-20个字符之间","Limit","1","20");
			  	build_validate("userPass","密码必须在1-20个字符之间","Limit","1","20");
			  	build_validate("userTel","请录入正确的电话号码","Phone","1","50");
			  	build_validate("userAddress","地址必须在1-50个字符之间","Limit","1","50");
			  	build_validate("userIDCode","身份证号码不正确","IdCard","15","18");
			  	build_validate_compare("userPass2","两次输入的密码不一致","userPass");
			  	build_validate("userZip","邮政编码格式不正确","Zip","6","6");
		    </script>
		</form>
	</body>
</html>
