<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8" import="java.sql.*"%><%
	String name = request.getParameter("UserName");
	name = new String(name.getBytes("ISO-8859-1"), "utf-8");
	//访问数据库，然后查询该用户名是否存在
/* 	Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
	Connection conn = DriverManager.getConnection(
			"jdbc:sqlserver://localhost:1433;databasename=movie", "sa", "sa");
 */
	Class.forName("com.mysql.jdbc.Driver");
	Connection conn=DriverManager.getConnection("jdbc:mysql://localhost:3306/movie","root", "root");
 
 	Statement stmt = conn.createStatement();
	String sql = "select * from users where username='" + name + "'";
	ResultSet rs = stmt.executeQuery(sql);
	if (rs.next()) {
		out.print("exist");
	} else {
		out.print("noexist");
	}
	rs.close();
	stmt.close();
	conn.close();
%>