package cn.com.systop.l08.listener;

import java.io.IOException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class LoginDo extends HttpServlet {

	private static final long serialVersionUID = 1L;

	protected  void doPost(HttpServletRequest req, 
		HttpServletResponse resp)throws IOException{
		String userName=req.getParameter("userName"); //获取文本框的值
		HttpSession session=req.getSession();
		session.setAttribute("userName", userName); //增加session属性
		resp.sendRedirect("index.jsp");
	}
}
