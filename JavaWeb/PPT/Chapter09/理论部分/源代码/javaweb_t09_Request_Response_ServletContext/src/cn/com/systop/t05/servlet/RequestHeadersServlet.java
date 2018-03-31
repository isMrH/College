package cn.com.systop.t05.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Enumeration;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class RequestHeadersServlet extends HttpServlet {

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        PrintWriter out = response.getWriter();
        Enumeration<String> e = request.getHeaderNames();
        while (e.hasMoreElements()) {
            String name = e.nextElement();//标识
            String value = request.getHeader(name);
            out.println("<font color=red>" + name + "</font>=" + value + "<br>");
        }
        out.close();

	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}
}
