<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.Type" %>
<%@ page import="com.MySql" %>
<%@ page import="java.util.*" %>
<% String path=request.getContextPath(); %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<style type="text/css">
*{
	margin:0px auto;
	padding:0px;
	list-style:none;
	font-size:14px;}
#father{
	margin-top:5px;
	width:1004px;
	height:auto;
	}
#login{
	width:900px;
	height:260px;
	margin-top:50px;
	}
h1{
	margin-left:10px;
	margin-top:5px;}
#login li{
	height:25px;
	}
#loginleft{
	float:left;
	text-align:right;
	width:120px;
	height:260px;
	}
#loginright{
	float:left;
	width:500px;
	height:300px;
	margin-left:15px;
	}
#btnmit{
	clear:both;
	margin-left:70px;
	width:80px;
	}	
span{
font-size:12px;}
</style>

<link type="text/css" rel="stylesheet" href="<%=path %>/cal/calendar-system.css"/>
<script type="text/javascript" src="<%=path %>/cal/calendar.js"></script>
<script type="text/javascript" src="<%=path %>/cal/calendar-en.js"></script>
<script type="text/javascript" src="<%=path %>/cal/calShow.js"></script> 
</head>
<body>
 <div id="father">
   <h1>添加电影DVD信息</h1>
   <form name="form2" method="post" action="doaction.jsp">
   <div id="login">
     <ul id="loginleft">
       <li>电影名称</li>
       <li>导演</li>
       <li>主演</li>
       <li>电影分类</li>
       <li>电影出产地区</li>
       <li>电影上映时间</li>
       <li>电影图片</li>
       <li>电影定价</li>
       <li>电影简介</li>
     </ul >
     <ul id="loginright">
       <li><input type="text" value="" name="moviename"/></li>
       <li><input type="text" value="" name="director"/></li>
       <li><input type="text" value="" name="statrdom"/></li>
       <li><select name="typeid">
            <% 
                 MySql ms=new MySql();
                 List list=ms.search();
                 for(int i=0;i<list.size();i++)
                 {
                     Type types=(Type)list.get(i);
                 %>
                	  <option value="<%=types.getTypeID() %>">
                	   <%=types.getTypeName() %>
                	 </option>
                <%
                 }
       
            %>
            
          </select>
       </li>
       <li><input type="text" value="" name="conntry"/></li>
       <li><input type="text" value=""  name="showtime" 
       readonly="true" onclick="calShow('showtime')"/>
       <span style="color:red;">&nbsp;*点击文本框弹出日历</span>
       </li>
       <li><input type="text" value="" name="picture"/></li>
       <li><input type="text" value="" name="money"/>
           
       
      </li>
       <li><textarea type="text" value="" name="content"></textarea></li>
     </ul>
   </div>
     <div id="btnmit"> <input type="submit" value="提交" id="btnmit"/></div>
     </form>
 </div>

</body>
</html>
