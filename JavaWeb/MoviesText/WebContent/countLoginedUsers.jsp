<%@ page language="java" pageEncoding="GBK"%>
<%@ page import="com.systop.*"%>
<%@ page import="java.util.*"%>
<html>
<%
	List loginedUsers = new ArrayList(); //�������б�
	//��ȫ�ַ�Χ��ȡ���������б�
	if (application.getAttribute("LOGINED_USER") != null) {
		loginedUsers = (List) application.getAttribute("LOGINED_USER");
	}
%>
<body>
<p align="center"><br><br><br>
�Ѿ���<%=loginedUsers.size()%>�˷��ʹ�����վ!<br><br>
�����ǣ�<br>
<%
		for (int i = 0; i < loginedUsers.size(); i++) {
		Users loginedUser = (Users) loginedUsers.get(i);
		out.print(loginedUser.getUserName());
		out.print("<br/>");
	}
%> 
</p>
</body>
</html>
