<%@ page language="java" pageEncoding="UTF-8"%>

<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    <title>添加电影分类</title>
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<link rel="stylesheet" type="text/css" href="<%=path%>/CSS/styles.css" />	
	<script src="<%=path%>/admin/validate.js" ></script>
	 <script>
  		function doSubmit(){
  			if (Validator.Validate(document.forms[0],3)) {
	  			document.forms[0].submit();
	  		}
		}
	  </script>	
  </head>  	
  <body> 
  	<form action="<%=path%>/admin/saveMovieType.jsp" method="post">
  		<div id="main" class="center">
	      <div id="context">
			<div class="c_title">添加电影分类信息</div>
			<div class="c_content"> 		  		
				<ul style="color:red;list-style-type:circle;">
				</ul>
			 	<table border="0">
				   	<tr>
			    		<th>电影分类名称</th>
			       		<td><input type="text" name="typeName" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			    </table>
				<div class="button_bar">
					<button onclick="javascript:doSubmit();">&nbsp;&nbsp;&nbsp;提  交&nbsp;&nbsp;&nbsp;</button>
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
	  	build_validate("typeName","电影分类名称必须在1-20个字符之间","Limit","1","20");
	  </script>
    </form>
  </body>
</html>