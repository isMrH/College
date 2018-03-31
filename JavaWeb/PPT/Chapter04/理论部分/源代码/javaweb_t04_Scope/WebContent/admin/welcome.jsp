<%@ page language="java" pageEncoding="UTF-8"%>
<%@ include file="checkSession.jsp" %>
<HTML>
<HEAD>
<TITLE></TITLE>
<link href="CSS/linkstyle.css" rel="stylesheet" type="text/css">
</HEAD>
<BODY BGCOLOR="#FFFFFF">
<br>
<center>
今天是 
<%
	//定义当前日期
	java.util.Date now = new java.util.Date();

	/*使用预定格式
	 *将日期转换为字符串
	 */
	java.text.SimpleDateFormat formater = new java.text.SimpleDateFormat(
			"yyyy年MM月dd日");
	String strCurrentTime = formater.format(now);

	//输出日期字符串到客户端浏览器
	out.println(strCurrentTime);
%>
</center>
<table width="100%" border="0" align="right" cellpadding="0"
	cellspacing="0">
	<tr>
		<td width="614" height="403"><img src="<%=request.getContextPath() %>/images/title_pic.jpg"
			width=590 height=433 alt="0"></td>
	</tr>
</table>

</BODY>
</HTML>
