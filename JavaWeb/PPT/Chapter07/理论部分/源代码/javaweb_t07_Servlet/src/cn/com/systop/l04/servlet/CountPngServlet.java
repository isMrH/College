package cn.com.systop.l04.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CountPngServlet
 */
public class CountPngServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	int count;

	public CountPngServlet() {
		super();
		count = 0;
	}

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		count++;
		out.println("<html>");
		out.println("<head><title>accessCounter</title></head>");
		out.println("<body bgcolor=\"#ffffff\">");
		out.println("You Called " + count + " times");
		out.println("</body></html>");
		out.close();
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}

}
