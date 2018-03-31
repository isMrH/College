<%@page import="cn.com.ambow.bean.Person"%>
<%@page import="cn.com.ambow.bean.Dog"%>
<%@page import="java.util.HashMap"%>
<%@page import="java.util.ArrayList"%>
<%@page import="org.apache.jasper.tagplugins.jstl.core.ForEach"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%--foreach标签 --%>
	<%
		int[] arr = new int[] { 10, 20, 43, 54, 59, 66 };
		pageContext.setAttribute("arr", arr);
		//循环输出数组中的值
		for (int i : arr) {
			out.print(i + "<br>");
		}
		//集合测试
		ArrayList al = new ArrayList();
		al.add("123");
		al.add("54");
		al.add("543");
		al.add("432");
		al.add("321");
		pageContext.setAttribute("al", al);

		//集合中存放自定义对象
		ArrayList al2 = new ArrayList();
		al2.add(new Dog("小哈", "京巴"));
		al2.add(new Dog("大金", "金毛"));
		al2.add(new Dog("唧唧", "吉娃娃"));
		al2.add(new Dog("蹦蹦", "鹿犬"));
		al2.add(new Dog("小萨", "萨摩耶"));
		pageContext.setAttribute("al2", al2);

		//Map测试
		HashMap hm = new HashMap();
		hm.put(1, "大牛");
		hm.put(2, "小强");
		hm.put(3, "小菜");
		hm.put(4, "小米");
		pageContext.setAttribute("hm", hm);

		//集合中存放自定义对象
		HashMap hm2 = new HashMap();
		hm2.put("二郎神", new Person("杨戬", 20, new Dog("哮天犬", "黑背")));
		hm2.put("城管", new Person("城市管理者", 20, new Dog("哈哈", "京巴")));
		hm2.put("小薇", new Person("周迅", 20, new Dog("神狐", "小白")));
		pageContext.setAttribute("hm2", hm2);
	%>
	<hr>
	<c:forEach items="${arr }" var="i">
		${i }<br>
	</c:forEach>
	<hr>
	<c:forEach items="${al }" var="item">
		${item }<br>
	</c:forEach>
	<hr>
	<c:forEach items="${hm }" var="m"><!-- 键——值 对 -->
		<%-- ${m.key }:${m.value }<br> --%>
		${m }<br>
	</c:forEach>
	<hr>
	<c:forEach items="${al2 }" var="item2"><!-- 对象 -->
		${item2.name}:${item2.type }<br>
	</c:forEach>
	<hr>
	<c:forEach items="${hm2 }" var="m2">
		<%--${m2.key }:${m2.value }<br> --%>
		${m2.key }:${m2.value.dog.name }<br>
	</c:forEach>
	<hr>
	<%--foreach标签其他属性 --%>
	<c:forEach begin="1" end="10" var="i" step="2" varStatus="myS">
		<%-- ${i }:<h4>come on baby……</h4> --%>
		${myS.current }<br>
	</c:forEach>
	<hr>
	<%--fortoken标签 --%>
	<c:forTokens items="张静初|周迅|陈冠希,东方神起|少女时代" delims="|," var="i" begin="2" end="4" step="2">
		${i }<br>
	</c:forTokens>
</body>
</html>