<%@ page language="java" pageEncoding="UTF-8"%>

<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.removeAttribute("msg");
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>小型电影DVD在线销售系统</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<link rel="stylesheet" type="text/css" href="<%=path%>/CSS/styles.css">
	<script type="text/javascript" src="validate.js"></script>
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

 	<div id="header" class="center">
	  	<img src="images/logo.jpg" style="width:238px;height:66px;text-align:left;"></img>	
	</div>
	<div id="main" class="center">
		  <div id="left">
			  	<div id="search">
			  		<div class="dia_title">查找电影</div>
			  		<div class="dia_content" style="height:150px;">
			  			&nbsp;
			  		</div>
			  		<div class="dia_foot"></div>
			  	</div>
			  	
			  	<div id="menu">
					<div class="dia_title">电影分类</div>
			  		<div class="dia_content2" style="height:359px;">
			  			<div class="list_item" style="height:359px;overflow-y:scroll;">
			  				<%-- 此处嵌入显示电影分类的页面showMoviesType.jsp --%>
			  				<%@ include file="/Type.jsp" %>
			  			</div>
			  		</div>
			  		<div class="dia_foot2">&nbsp;</div>
			  	</div> <!-- end of menu -->
		  	</div> <!-- end of left --> 
		  	<div id="middle">
			  		<div class="m_title">
			  			<img src="<%=path%>/images/title_pic.jpg" width="355" height="175">
			  		</div>
			  		<div class="bar"></div>
			  		<div class="m_content" style="height:369px;width:340px;overflow-y:scroll;">
						<%@ include file="/moviesList.jsp" %>
			  		</div>
			  		<div class="m_foot">
			  		</div>
		  	</div><!-- end of middle --> 
		  	 <div id="right">
			  	<div id="search">
			  		<div class="dia_title">电影DVD在线销售</div>
			  		<div class="dia_content" style="height:150px;padding:12px 2px 0 15px;">
			  			
						<%--<div id="dvOnline" style="display:block;height:137px;background:url(images/myDVD.gif)  no-repeat;">
				  			<span id="spUsername" style="font-weight:bold;"><%=((Users)session.getAttribute("user")).getUserName() %></span>   大驾光临
				  			<ul style="color:#0c0c0c;list-style-type:circle;margin:8px 16px;">
							 	<li><a href="<%=path%>/admin/toAddDVD.jsp">添加电影DVD</a></li>
							 </ul>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							 <a href="<%=path%>/admin/doLogout.jsp" class="a_button">注销</a> 
			  			</div>
			  			--%>
			  			
						<div id="dvLogin">
						<form action="<%=path%>/admin/doLogin.jsp" method="post">
						<input type="hidden" name="operate" value="doLogin">
			  			用户名：<input type="text" name="userName" id="usr" style="width:60px;" /> <br />
			  			密&nbsp;&nbsp;&nbsp;&nbsp;码：<input type="password" name="passWord" id="pwd" style="width:60px;" /> 
			  			<br />
			  			<a href="<%=path%>/admin/register.jsp" class="a_button">用户注册</a>&nbsp;
			  			<button class="button" onclick="javascript:doLogin();" style="width:40px;">登录</button> <br />  
			  			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			  			<img src="images/login.gif" style="width:75px;"></img>
			  			</form>
			  			</div>
						
					</div>
			  		<div class="dia_foot"></div>
			  	</div>
			  	<div id="menu">
					<div class="dia_title">正在热卖</div>
			  		<div class="dia_content2" style="height:357px;">
			  			<div class="list_item">
			  				<img src="images/arr.gif">&nbsp; <a href="#" class="menu"></a>
			  			</div>
			  			
			  		</div>
			  		<div class="dia_foot2">&nbsp;</div>
			  	</div> <!-- end of menu -->
		  	</div> <!-- end of right --> 
      </div> <!-- end of main -->
	  <div id="footer" class="center">
	  </div>
  	    
  </body>
</html>
