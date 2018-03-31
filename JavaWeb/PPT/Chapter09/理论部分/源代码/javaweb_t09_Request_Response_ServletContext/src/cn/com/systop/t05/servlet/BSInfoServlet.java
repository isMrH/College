package cn.com.systop.t05.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class BSInfoServlet extends HttpServlet {

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html;charset=gb2312");
		PrintWriter out = response.getWriter();
		// 返回发出请求的客户端的IP地址
		out.println("客户端IP地址:" + request.getRemoteAddr() + "<br>");
		// 返回发出请求的客户端的的完整主机名
		out.println("主机名:" + request.getRemoteHost() + "<br>");
		// 返回发出请求的客户端所使用的网络接口的端口号
		out.println("客户端端口号:" + request.getRemotePort() + "<br>");
		// 返回Web服务器上接收当前请求的网络接口的IP地址
		out.println("服务器IP地址:" + request.getLocalAddr() + "<br>");
		// 返回Web服务器上接收当前请求的网络接口的IP地址所对应的主机名
		out.println("服务器主机名:" + request.getLocalName() + "<br>");
		// 返回Web服务器上接收当前请求的网络接口的端口号
		out.println("服务器端口号:" + request.getLocalPort() + "<br>");
		// 返回当前请求所指向的主机名
		out.println("当前请求所指向的主机名:" + request.getServerName() + "<br>");
		// 返回当前请求所连接的服务器端口号
		out.println("当前请求所连接的服务器端口号:" + request.getServerPort() + "<br>");
		// 返回请求的协议名
		out.println("请求的协议名:" + request.getScheme() + "<br>");
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}

}
