<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<table width="50%" border="1">
	<form action="AddMessageServlet">
		<tr bgcolor="#999999">
			<td height="42" colspan="3">
				<div align="center">
					<span>留言板</span>
				</div>
			</td>
		</tr>
		
		<tr>
			<td width="28%" height="36">
				姓名：
			</td>
			<td colspan="2">
				<input type="text" name="messName" />
			</td>
		</tr>
		
		<tr>
			<td height="41">
				主题：
			</td>
			<td colspan="2">
				<input type="text" name="title" />
			</td>
		</tr>
		
		<tr>
			<td height="93">
				留言：
			</td>
			<td colspan="2">
				<textarea name="content" row="8" cols="30"></textarea>
			</td>
		</tr>
		<tr bgcolor="#999999">
			<td height="60" colspan="3">
				<label>
					<div align="center">
						<input type="submit" value="提交留言" />
						&nbsp;&nbsp;&nbsp;&nbsp;
						<input type="reset" value="重新编写" />
					</div>
				</label>
			</td>
		</tr>
	</form>
</table>
</body>
</html>