<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.systop.*" %>
<%@ page import="java.util.*" %>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.removeAttribute("msg");
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<base href="<%=basePath%>">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" type="text/css" href="CSS/styles.css">
<link rel="stylesheet" type="text/css" href="<%=path %>/cal/calendar-system.css">
<script type="text/javascript" src="<%=path %>/cal/calendar.js"></script>
<script type="text/javascript" src="<%=path %>/cal/calendar-en.js"></script>
<script type="text/javascript" src="<%=path %>/cal/calShow.js"></script>
<script type="text/javascript" src="<%=path %>/cal/validate.js"></script>
<script type="text/javascript">
		function doSubmit(){
			if (Validator.Validate(document.forms[0],3)){
				document.forms[0].submit();
			}
			//document.forms[0].submit();
		}
		function setMoviesPic(url){
			var oImg=document.getElementById("img");
			oImg.src=url;
			oImg.style.height="240px";
		}
	</script>
</head>
<body>
	<form method="post" action="doAddMovies.jsp">
		<div style="width:1000px;">
			<div class="c_title"> 添加电影DVD信息</div>
			<div class="c_content">
				电影名称<input type="text" name="movieName"/><font color="red">*</font><br/>
				 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;导演<input type="text" name="director" /><font color="red">*</font><br/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;主演<input type="text" name="stardom" /><font color="red">*</font><br/>
				电影分类<select name="type">
				<%--循环生成电影分类下拉列表选项 --%>
				<%
					//创建电影分类数据库访问对象
					TypeDao td=new TypeDao();
					List list=td.getType();
					for(int i=0;i<list.size();i++){
						Type type=(Type)list.get(i);
				%>
					<option value="<%=type.getTypeID() %>"><%=type.getTypeName() %></option>
				<%
					}
				%>
				</select><font color="red">*</font><br/>
				出产地区<input type="text" name="regin" /><span style="color:red;">*</span><br/>
				上映时间<input type="text" name="showtime" readonly="readonly" onclick="calShow('showtime')" /><font color="red">*点击文本框弹出日历</font><br/>
				电影简介<textarea rows="5" cols="10" name="description"></textarea><font color="red">*</font><br/>
				电影图片<input type="text" name="image" onblur="setMoviesPic(this.value)" value="images/movies/" /><span style="color:red;">*在“images/movies/”后录入图片名称即可</span><br/>
				电影定价<input type="text" name="price" /><font color="red">*</font><br/>
				<div align="center"><button onclick="doSubmit();">提交</button></div>
			</div>
			<div class="c_foot"><img id="img" alt="" src=""></div>
		</div>
	
	</form>
	<script>
		build_validate("movieName","电影名称必须在1-50个字符之间","Limit","1","50");
		build_validate("director","导演必须在1-50个字符之间","Limit","1","50");
		build_validate("stardom","主演必须在1-50个字符之间","Limit","1","50");
		build_validate("type","电影分类名称不能为空","Limit","1","1");
		build_validate("regin","电影出产地区必须在1-10个字符之间","Limit","1","10");
		build_validate("showtime","电影上映时间格式不正确","Limit","10","10");
		build_validate("description","电影简介必须在1-500个字符之间","Limit","1","500");
		build_validate("image","电影图片必须在1-50个字符之间","Limit","1","50");
		build_validate("price","电影定价格式不正确","Currency","1","50");
	</script>	
</body>
</html>