<%@ page language="java" pageEncoding="UTF-8"%>

<html>
  <head>
     <title>JSP表达式</title>
  </head>
  
  <body>
  	<h1>JSP表达式</h1>
    <b>	PI的值：</b><%=Math.PI %><br>
    <b>	1000,999中最大的值：</b><%=Math.max(1000,999) %><br>
    <b>	1000,999中最小的值：</b><%=Math.min(1000,999) %><br>
    <b>	1+2-3的值：</b><%=1+2-3 %><br>
    <b>	1+2 == 3的值：</b><%=1+2 == 3 %><br>
    <b>	1+2 != 3的值：</b><%=1+2 != 3 %><br>
  </body>
</html>
