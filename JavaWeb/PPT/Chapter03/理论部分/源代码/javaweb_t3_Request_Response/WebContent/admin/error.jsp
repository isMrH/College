<%@ page language="java" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<HTML>
<HEAD>
<TITLE>小型电影DVD在线销售系统</TITLE>
</HEAD>
<BODY BGCOLOR=#FFFFFF LEFTMARGIN=0 TOPMARGIN=0 MARGINWIDTH=0 MARGINHEIGHT=0>

<table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td colspan="5"><img src="<%=path %>/images/title_pic.jpg" width="780" height="213"></td>
  </tr>
  <tr>
    <td colspan="5"><img src="<%=path %>/images/middle1.jpg" width="780" height="47"></td>
  </tr>
  <tr>
    <td width="38" background="<%=path %>/images/middle2.jpg">&nbsp;</td>
    <td width="172"></td>
    <td width="35" background="<%=path %>/images/middle3.jpg">&nbsp;</td>
    <td width="495" align="center">
	    
		<img src="<%=path %>/images/error.jpg" width="132" height="59" />
	</td>
    <td width="40" background="<%=path %>/images/middle4.jpg">&nbsp;</td>
  </tr>
  <tr>
    <td colspan="5"><img src="<%=path %>/images/bottom.jpg" width="780" height="82"></td>
  </tr>
</table>
<P align="center">冀ICP备08001534号 国家火炬计划河北省软件产业IT人才实训基地 版权所有</P>
<br/>
</BODY>
</HTML>