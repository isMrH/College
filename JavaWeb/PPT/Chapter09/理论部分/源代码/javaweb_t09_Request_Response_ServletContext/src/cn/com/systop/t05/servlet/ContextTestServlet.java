package cn.com.systop.t05.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class ContextTestServlet extends HttpServlet {
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//获得ServletContext对象
		ServletContext context=this.getServletContext();
		 //设置HTTP响应的正文的MIME类型及字符编码
		response.setContentType("text/html;charset=GB2312");
		/*输出HTML文档*/
		PrintWriter out = response.getWriter();
		out.println("<html><head><title>ContextTestServlet</TITLE></head>");
		out.println("<body>");
		//根据给定的参数名，返回Web应用范围内的匹配的初始化参数值
		out.println("<br>Email: "+context.getInitParameter("weburl"));
		//根据参数指定的虚拟路径，返回文件系统中的一个真实的路径
		out.println("<br>Path: "+context.getRealPath("/WEB-INF"));
		//返回参数指定的文件的MIME类型
		out.println("<br>MimeType: "+context.getMimeType("/WEB-INF/web.xml"));
		//返回Servlet容器支持的Java Servlet API的主版本号
		out.println("<br>MajorVersion: "+context.getMajorVersion());
		//返回Servlet容器的名字和版本
		out.println("<br>ServerInfo: "+context.getServerInfo());
		out.println("</body></html>");    
		out.close(); //关闭PrintWriter
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}
}
