<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Type" %>
<%@ page import="cn.com.systop.jspt06.dao.TypeDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.TypeDAOImpl" %>
<%@ include file="checkSession.jsp"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    <title>添加电影DVD信息</title>
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<link rel="stylesheet" type="text/css" href="<%=path%>/CSS/styles.css" />
	<link type="text/css" rel="stylesheet" href="<%=path%>/cal/calendar-system.css"/>
	<script type="text/javascript" src="<%=path%>/cal/calendar.js"></script>
	<script type="text/javascript" src="<%=path%>/cal/calendar-en.js"></script>
	<script language="JavaScript" src="<%=path%>/cal/calShow.js" ></script>
	<script src="<%=path%>/admin/validate.js" ></script>
	 <script>
  		function doSubmit(){
  			if (Validator.Validate(document.forms[0],3)) {
	  			document.forms[0].submit();
	  		}
		}
		function setMoviesPic(url){
			var oImg = document.getElementById("moviesPic");
			oImg.src = url;
			//alert(oImg.src);
			oImg.style.height = "240px";
		}
	  </script>	
  </head>  	
  <body> 
  	<form action="<%=path%>/admin/saveMovieInfo.jsp" method="post">
  		<div id="main" class="center">
	      <div id="context">
			<div class="c_title">添加电影DVD信息</div>
			<div class="c_content"> 		  		
				<ul style="color:red;list-style-type:circle;">
				</ul>
			 	<table border="0">
				   	<tr>
			    		<th>电影名称</th>
			       		<td><input type="text" name="movieName" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			        <tr>
			    		<th>导演</th>
			       		<td><input type="text" name="director" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			        <tr>
			    		<th>主演</th>
			       		<td><input type="text" name="stardom" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			        <tr>
			    		<th>电影分类</th>
			       		<td>
			       			<select name="typeID">
			       				<%-- 循环生成电影分类下拉列表选项 --%>
			       				<% 
									TypeDAO typeDAO = new TypeDAOImpl();//创建电影分类数据库访问类对象
									List list = typeDAO.search();//查询电影分类列表
									//循环遍历电影分类列表生成电影分类下拉列表选项
									for(int i=0; i<list.size(); i++) {
										Type type = (Type)list.get(i);
								%>	
										<option value="<%=type.getTypeID() %>"><%=type.getTypeName() %></option>
								<% 
									}
								%>
			       			</select>
			       			<span style="color:red;">&nbsp;*</span>
			       		</td>
			        </tr>
			        <tr>
			    		<th>电影出产地区</th>
			       		<td><input type="text" name="region" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			        <tr>
			    		<th>电影上映时间</th>
			       		<td><input type="text" name="showtime" readonly="true" onclick="calShow('showtime');"/><span style="color:red;">&nbsp;*点击文本框弹出日历</span></td>
			        </tr>
			        <tr>
			    		<th>电影简介</th>
			       		<td><textarea name="description" rows="5"></textarea><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			        <tr>
			    		<th>电影图片</th>
			       		<td><input type="text" name="image" onblur="javascript:setMoviesPic(this.value);" value="images/movies/"/><span style="color:red;">&nbsp;*在"images/movies/"后录入图片名称即可</span></td>
			        </tr>
			        <tr>
			    		<th>电影定价</th>
			       		<td><input type="text" name="price" /><span style="color:red;">&nbsp;*</span></td>
			        </tr>
			    </table>
				<div class="button_bar">
					<button onclick="javascript:doSubmit();">&nbsp;&nbsp;&nbsp;提  交&nbsp;&nbsp;&nbsp;</button>
		        </div>
		        <img id="moviesPic" src="<%=path%>/images/preview.jpg" style="border:solid 1px green;" />
				<div class="c_foot">&nbsp;</div>
			</div><%--end of c_content --%>
		  	<div class="c_foot">&nbsp;</div>
		  </div><%--end of context --%>
		</div><%--end of main --%>
	  <script>
	  	build_validate("movieName","电影名称必须在1-50个字符之间","Limit","1","50");
	  	build_validate("director","导演必须在1-50个字符之间","Limit","1","50");
	  	build_validate("stardom","主演必须在1-50个字符之间","Limit","1","50");
	  	build_validate("typeID","电影分类名称不能为空","Limit","1","1");
	  	build_validate("region","电影出产地区必须在1-10个字符之间","Limit","1","10");
	  	build_validate("showtime","电影上映时间格式不正确","Limit","10","10");
	  	build_validate("description","电影简介必须在1-500个字符之间","Limit","1","500");
	  	build_validate("image","电影图片必须在1-50个字符之间","Limit","1","50");
	  	build_validate("price","电影定价格式不正确","Currency","1","50");
	  </script>
    </form>
  </body>
</html>