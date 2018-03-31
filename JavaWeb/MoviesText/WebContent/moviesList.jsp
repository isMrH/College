<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>
<%@ page import="com.systop.*" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" type="text/css" href="CSS/liststyle.css" />
</head>
<body>
<%
String sTypeID=request.getParameter("typeID");
if(sTypeID!=null){
	int typeid=Integer.parseInt(sTypeID);
	//根据电影分类id获取电影信息列表，暂不分页，取第一页信息
	MoviesDao moviesdao=new MoviesDao();
	List movieslist=moviesdao.searchMovies(typeid);
    if(movieslist != null && movieslist.size() != 0) {
    	for(int i=0; i<movieslist.size(); i++) {
    		Movies movie = (Movies)movieslist.get(i);
%>
<div class="movies_pic"><img src="<%=movie.getImage() %>" title="<%=movie.getDescription() %>" style="width:100px;border:dashed 1px green;"></img></div>
<div class="movies_info" style="border:solid 0px blue;">
<strong><%=movie.getMovieName() %></strong><br />
<span class="info_title">导&nbsp;演</span>&nbsp;<em><%=movie.getDirector() %></em> <br />
<span class="info_title">主&nbsp;演</span>&nbsp;<span style="color:green;"><%=movie.getStardom() %></span><br />
<span class="info_title">地&nbsp;区</span>&nbsp;<b><%=movie.getRegin() %></b><br />
<span class="info_title">上映日期</span>&nbsp;<b><%=movie.getShowtime().substring(0,10) %></b><br />
<span class="info_title">电影简介</span>&nbsp;<b><%=movie.getDescription().length()>40?movie.getDescription().substring(0,40) + "......":movie.getDescription() %></b>
</div>
<div style="clear:both;"></div>
<%
		}
	}
}
%>
<div style="padding-top:7px;padding-left:;3px "><img style="width:333px;" src="images/hline3.gif"></div>
<div class="page_info"></div>
</body>
</html>