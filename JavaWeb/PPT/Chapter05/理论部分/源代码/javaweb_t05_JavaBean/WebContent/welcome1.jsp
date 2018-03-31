<%@ page language="java" contentType="text/html; charset=gb2312"
    pageEncoding="gb2312"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
    <head>
        <title>欢迎来到JSP学习园地</title>
    </head>
    <body>
        <h1 align="center">欢迎<%=request.getParameter("username") %>来到JSP学习园地</h1>
    </body>
</html>