<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%!
	//声明一个常量
	public static final String SEPARATOR = ".";
	
	//将整数金额自动转换为带两位小数的金额
	public String convertMoney(String money) {
		int index = money.indexOf(SEPARATOR);
		String strMoney = null;
		if(index == -1) {
			strMoney = money + ".00";
		}
		return strMoney;
	}
 %>
<html>
  <head>
    <title>JSP声明</title>
  </head>
  
  <body>
    <%
    	String money1 = "1000";
    	String newMoney1 = convertMoney(money1);
    	String money2 = "999";
    	String newMoney2 = convertMoney(money2);
     %>
     <table align="center" border="1" width="50%">
     	<caption>将整数金额自动转换为带两位小数的金额</caption>
     	<tr>
     		<td>转化前</td>
     		<td>转化后</td>
     	</tr>
     	<tr>
     		<td><%=money1 %></td>
     		<td><%=newMoney1 %></td>
     	</tr>
     	<tr>
     		<td><%=money2 %></td>
     		<td><%=newMoney2 %></td>
     	</tr>
     </table>
  </body>
</html>
