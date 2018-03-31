<%@ page language="java" import="java.util.*" pageEncoding="gb2312"%>
<html>
<head>
<style type="text/css">
td img {display: block;}.STYLE1 {
	font-size: 12px;
	color: #276388;
	font-weight: bold;
}
body {
	margin-top: 50px;
}
.STYLE3 {font-size: 12px; color: #276388; font-weight: bold; font-family: "??"; }
</style>
</head>
<body bgcolor="#ffffff">
<form action="/jlls/login.do?method=login" method="post" name="form1" >
<table width="757" height="108" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="493" align="center"><table width="288" height="157" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td width="66" rowspan="4" align="right"><img src="images/dl_r2_c1.jpg" width="18" height="147" /></td>
                <td colspan="2"><img src="images/dl_r2_c2.jpg" width="253" height="43" /></td>
                <td width="17" rowspan="4"><img src="images/dl_r2_c7.jpg" width="17" height="147" /></td>
              </tr>
              <tr>
                <td width="99" height="46" align="right"><span class="STYLE3">ÓÃ»§Ãû:</span></td>
                <td width="154" align="left">
                  <input name="username" type="text" size="15" /></td>
              </tr>
              <tr>
                <td align="right"><span class="STYLE3">ÃÜ&nbsp;&nbsp;Âë:</span></td>
                <td align="left"><span class="STYLE1">
                  <input name="password" type="password" size="15" />
                </span></td>
              </tr>
              <tr>
                <td height="52" align="center"><a href="#" onclick="empty()"><img src="images/dd_r1_c1.jpg" width="60" height="21" border="0"/></a></td>
                <td height="52" align="center"><a href="#" onclick="form1.reset()"><img src="images/dd_r1_c3.jpg" width="61" height="21" border="0"/></a></td>
              </tr>
          </table>
</form>
</body>
</html>
