<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ page import="java.text.SimpleDateFormat" %>

<html>
  <head>
    <title>动态输出服务器端当前日期</title>
  </head>
  <!--这是客户端查看源代码能够看到的注释，叫做HTML注释  -->
  <%--这是客户端查看源代码看不到的注释，叫做JSP注释 --%>
  <body>
    hello呀！服务器端当前日期是：
    <%
    	SimpleDateFormat sdf = new SimpleDateFormat("yyyy年MM月dd日");
    	String currentDate = sdf.format(new Date());
     %>
     <%=currentDate %>
  </body>
</html>
