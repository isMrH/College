<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ page import="cn.com.systop.jspt06.entity.Movies" %>
<%@ page import="cn.com.systop.jspt06.dao.MoviesDAO" %>
<%@ page import="cn.com.systop.jspt06.dao.impl.MoviesDAOImpl" %>

<%
	String sTypeID = request.getParameter("typeID");
	if (sTypeID != null) {
		int typeID = Integer.parseInt(sTypeID);
	    //根据电影分类ID获取电影DVD信息列表,暂不分页，只取出第一页信息
	    MoviesDAO moviesDAO = new MoviesDAOImpl();
	    List moviesList = moviesDAO.search(1, typeID);
	    if(moviesList != null && moviesList.size() != 0) {
	    	for(int i=0; i<moviesList.size(); i++) {
	    		Movies movie = (Movies)moviesList.get(i);
%>
<div class="movies_pic"><img src="<%=movie.getImage() %>" title="<%=movie.getDescription() %>" style="width:100px;border:dashed 1px green;"></img></div>
<div class="movies_info" style="border:solid 0px blue;">
	<strong><%=movie.getMovieName() %></strong><br />
	<span class="info_title">导&nbsp;演</span>&nbsp;<em><%=movie.getDirector() %></em> <br />
	<span class="info_title">主&nbsp;演</span>&nbsp;<span style="color:green;"><%=movie.getStardom() %></span><br />
	<span class="info_title">地&nbsp;区</span>&nbsp;<b><%=movie.getRegion() %></b><br />
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
	