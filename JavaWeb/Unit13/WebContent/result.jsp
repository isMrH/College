<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>春晚节目投票结果</title>

<script language="javascript">
	var xmlHttpRequest=null;
	function createXmlHttpRequest(){
		try{
			return new ActiveXObject("Msxml2.XMLHTTP");
		}catch(e){
			try{
				return new ActiveXObject("Microsoft.XMLHTTP");
			}catch(e){
				try{return new XMLHttpRequest();
				}catch(e){}
			}
		}
	}
	function getResult(){
		xmlHttpRequest = createXmlHttpRequest();
	
		xmlHttpRequest.onreadystatechange=showResult;
		xmlHttpRequest.open("GET","GetVoteResultServlet",true);
		xmlHttpRequest.send(null);
	}
	function showResult(){
		if(xmlHttpRequest.readyState==4){
			if(xmlHttpRequest.status==200){
				var inhtml=xmlHttpRequest.responseText;
				document.getElementById("result").innerHTML=inhtml;
			}
			else{
				alert("请求发送异常，异常编号："+xmlHttpRequest.status);
			}
		}
	}
	function init(){
		setInterval("getResult()",5000);
	}
</script>
</head>
<body onLoad="getResult();init();">

<table width="400" border="1" cellspacing="0" cellpadding="0">
	<tr>
		<td width="400" height="30" align="center">
			<strong>位喜爱的春晚节目在线投票评选</strong>
		</td>
	</tr>
	<tr>
		<td height="30">发起人：CCTV.com</td>
	</tr>
	<tr>
		<td height="30">详细内容：请您投下宝贵的一票吧！</td>
	</tr>
	<tr>
		<td height="30">当前投票结果：</td>
	</tr>
	<tr>
		<td>
			<div id="result"></div>
		</td>
	</tr>
	<tr>
		<td align="center">
			<a href="vote.jsp">返回</a>
		</td>
	</tr>
</table>
</body>
</html>