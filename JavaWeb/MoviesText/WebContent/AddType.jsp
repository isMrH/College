<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" type="text/css" href="CSS/styles.css">
<script type="text/javascript">
		function doLogin(){
			var name  = document.getElementById("name");
			if (name.value==""){
				alert("电影分类名称不能为空");
				name.focus();
				return false;
			}
		}
	</script>
</head>
<body>
	<form method="post" action="doAddType.jsp">
		<div style="width:1000px;">
			<div class="c_title"> 添加电影分类信息</div>
			<div class="c_content">
				电影分类名称<input id="name" type="text" name="typeName" /><font color="red">*</font><br/><br/>
				<div align="center"><button type="submit" value="提交" onclick="return doLogin()" >提交</button></div>
			</div>
			<div class="c_foot"><img alt="" src="images/title_pic.jpg"></div>
		</div>
		
	</form>
</body>
</html>