<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<%@ page import="com.Type" %>
<%@ page import="com.MySql" %>
<%@ page import="java.util.*"%>
<% String path=request.getContextPath(); %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Insert title here</title>

<style type="text/css">
*{
   margin:0px auto;
   padding:0px;
   list-style:none;
}
.father{
   width:1004px;
   height:800px;
   border:1px solid #c1c1c1;
}
.title{
   padding-top:25px;
   background-color:#c1c1c1;
   height:60px;
}
.content{
   padding-top:20px;
   margin-left:300px;
}
.content li{
   height:40px;
   line-hight:30px;
   
}

#left li{
   width:120px;
 }
#right li{
   width:480px;
 }
#left{
   float:left;
   text-align:right;
}
#right{
   margin-left:10px;
   float:left;
}
#clear{
   clear:both;
}
#foot{
   margin-top:80px;
   text-align:center;
 
}
#moviesPic{
   text-align:center;
}
input{
  border:gray 1px solid;
}
select{border:gray 1px solid;}
textarea{border:gray 1px solid;}
span{
font-size:12px;}
</style>
<link type="text/css" rel="stylesheet" href="/MovieTest/cal/calendar-system.css"/>
<script type="text/javascript" src="/MovieTest/cal/calendar.js"></script>
<script type="text/javascript" src="/MovieTest/cal/calendar-en.js"></script>
<script type="text/javascript" src="/MovieTest/cal/calShow.js"></script> 
<script src="/MovieTest/cal/validate.js"></script>
<script>
  function setMoviesPic(url){
       var oImg = document.getElementById("moviesPic");
       oImg.src = url;
       oImg.style.height = "240px";
	  }
  function duSubmit(){
       if(Validator.Validate(document.forms[0],3)){
           document.forms[0].submit();
       }
  }
</script>
</head>
<body>
<form method="post" action="dotest.jsp">
   <div class="father">
      <div class="title"><h2>添加电影DVD信息</h2></div>
      <div class="content">
         <ul id="left">
               <li>电影名称：</li>
               <li>导演：</li>
               <li>主演：</li>
               <li>电影分类：</li>
               <li>电影出产地区：</li>
               <li>电影上映时间：</li>
               <li>电影图片：</li>
               <li>电影定价：</li>
               <li id="jianjie">电影简介：</li>
         </ul>
         <ul id="right">
              <li><input type="text" name="movieName" style="width:150px;"></input></li>
              <li><input type="text" name="director" style="width:150px;"></input></li>
              <li><input type="text" name="stardom" style="width:150px;"></input></li>
              <li><select name="typeid" style="width:155px;">
                   <%
                      MySql ms = new MySql();
                      List list = ms.search();
                      for(int i=0;i<list.size();i++){
                    	  Type type=(Type)list.get(i);
                   %>
                      <option value="<%=type.getTypeID() %>"><%=type.getTypeName() %></option>
                    <%
                      }
                    %>
                  </select></li>
              <li><input type="text" name="region" style="width:150px;"></input></li>
               <li><input type="text" value=""  name="showtime" id="showtime"
                readonly="readonly" onclick="calShow('showtime')"/><span style="color:red";>*点击文本框弹出日历</span>
               </li>
              
              <li><input type="text" name="image" style="width:150px;"
                onblur="setMoviesPic(this.value);" value="/MovieTest/images/movies/"></input><span style="color:red";>*在MovieTest/images/movies/后录入图片名称即可</span></li>
              <li><input type="text" name="price" style="width:150px;"></input></li>
              <li id="text"><textarea name="description" style="width:300px;height:100px"></textarea></li>
         </ul>
      </div>
      <div id="clear"></div>
      <div id="foot"><button onclick="duSubmit();">提交</button></div>
      <img id="moviesPic" alt="" src="">
   </div>
   <script>
   build_validate("movieName","电影名称必须在1-50个字符之间","Limit","1","50");
   build_validate("director","导演必须在1-50个字符之间","Limit","1","50");
   build_validate("stardom","主演必须在1-50个字符之间","Limit","1","50");
   build_validate("typeid","电影分类名称不能为空","Limit","1","1");
   build_validate("region","电影出产地必须在1-10个字符之间","Limit","1","10");
   build_validate("showtime","电影上映格式不正确","Limit","10","10");
   build_validate("image","电影图片必须在1-50个字符之间","Limit","1","50");
   build_validate("price","电影价格输入不正确","Currency","1","50");
   build_validate("description","电影简介必须在1-500个字符之间","Limit","1","500");
         
   </script>
</form>
</body>
</html>