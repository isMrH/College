package cn.com.systop.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class HelloServlet extends HttpServlet {
	private static final long serivalVersionUID=1L;
	public HelloServlet(){
		super();
	}
	protected void doGet(HttpServletRequest request,HttpServletResponse response) 
	throws ServletException, IOException{
		response.setContentType("text/html;charset=gb2312");
		PrintWriter out=response.getWriter();
		out.println("<HTML>");
		out.println("	<HEAD><TITLE>ÄãºÃServlet</TITLE></HEAD>");
		out.println("	<BODY>");
		out.print("ÄãºÃ,Servlet");
		out.println("	</BODY>");
		out.println("</HTML>");
		out.flush();
		out.close();
	}
	protected void doPost(HttpServletRequest request,HttpServletResponse response) 
	throws ServletException, IOException{	
		this.doGet(request, response);
	}
}
