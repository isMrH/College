package cn.com.systop.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CountPngServlet extends HttpServlet{
	private static final long serialVersionUID=1L;
	int count;
	public CountPngServlet(){
		super();
		count=0;
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
	
		PrintWriter out=response.getWriter();
		count++;
		out.println("<HTML>");
		out.println("	<HEAD><TITLE>accessCounter</TITLE></HEAD>");
		out.println("	<BODY bgcolor=\"#ffffff\">");
		out.println("You Called " + count + " times");
		out.println("	</BODY>");
		out.println("</HTML>");

		out.close();
	}
	@Override
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		this.doGet(request, response);
	}
}
