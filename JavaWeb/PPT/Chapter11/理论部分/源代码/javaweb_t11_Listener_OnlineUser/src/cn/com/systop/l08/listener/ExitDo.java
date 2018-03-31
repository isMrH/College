package cn.com.systop.l08.listener;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

 public class ExitDo extends javax.servlet.http.HttpServlet implements 	javax.servlet.Servlet {
	private static final long serialVersionUID = 1L;	

	protected void doGet(HttpServletRequest req, HttpServletResponse resp) 		
	throws ServletException, IOException {
		req.getSession().removeAttribute("userName");		
		resp.sendRedirect("login.jsp");
	}
}
