package cn.com.systop.t05.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class RequestLineServlet extends HttpServlet {
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html;charset=gb2312");
        PrintWriter out = response.getWriter();
        //返回HTTP请求消息中的请求方式(如GET、POST)
        out.println("请求方式:" + request.getMethod() + "<br>"); 
        //返回请求行中的资源名部分
        out.println("资源名部分:" + request.getRequestURI() + "<br>");
        //返回请求行中的参数部分
        out.println("参数部分:" + request.getQueryString() + "<br>"); 
        //返回请求行中的协议名和版本
        out.println("协议名和版本:" + request.getProtocol() + "<br>"); 
        //返回请求URL所属于的Web应用程序的路径
        out.println("Web应用程序的路径:" + request.getContextPath() + "<br>");
        //返回请求URL中的额外路径信息
        out.println("额外路径信息:" + request.getPathInfo() + "<br>"); 
        //返回Servlet的名称或Servlet所映射的路径
        out.println("Servlet所映射的路径:" + request.getServletPath() + "<br>"); 

	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}
}
