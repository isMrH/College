package com.test.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.test.dao.UserDao;
import com.test.model.UserInfo;

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
		// TODO Auto-generated method stub
		this.doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//编码
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;charset=UTF-8");
		//拿参		
		String name = request.getParameter("name");
		String pwd = request.getParameter("pwd");
		//dao
		UserDao userDao = new UserDao();
		//如果user为空表示，没有用户，否则表示登陆成功
		UserInfo user = userDao.login(name, pwd);
		
		String url = "";
		if(user != null){
			HttpSession session = request.getSession();
			session.setAttribute("userInfo", user);
			url = "index.jsp";
		}else{
			request.setAttribute("error", "用户名密码错误");
			url = "login.jsp";
		}
		request.getRequestDispatcher(url).forward(request, response);		
	}

}
