package cn.com.systop.l07.controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.com.systop.l07.javabean.UserBean;

/**
 * Servlet implementation class LoginServlet
 */
public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public LoginServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		this.doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		UserBean userBean=new UserBean();
		//接收用户提交的用户名和密码
		String username=request.getParameter("userName");
		String pwd=request.getParameter("userPassword");
		//给UserBean属性赋值
		userBean.setUserName(username);
		userBean.setUserPassword(pwd);
		request.setAttribute("loginUser", userBean);
		// 登录验证
		if(userBean.login()){
			request.getRequestDispatcher("/success.jsp").forward(request, response);
		}
		else {
			request.getRequestDispatcher("/login.jsp").forward(request, response);
		}
		
	}

}
