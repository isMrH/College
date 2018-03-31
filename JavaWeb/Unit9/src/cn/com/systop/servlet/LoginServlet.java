package cn.com.systop.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

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
		String loginname=request.getParameter("loginname");
		String loginpwd=request.getParameter("loginpwd");
		if(loginname.equals("systop")&& loginpwd.equals("systop")){
			//创建登录用户名cookie
			Cookie cookie_name=new Cookie("loginname",loginname);
			//创建密码
			Cookie cookie_pwd=new Cookie("loginpwd",loginpwd);
			//设置过期时间10秒
			cookie_name.setMaxAge(10);
			cookie_pwd.setMaxAge(10);
			//吧cookie写入客户端
			response.addCookie(cookie_name);
			response.addCookie(cookie_pwd);
			//创建session
			HttpSession session=request.getSession();
			//设置session失效时间30分钟
			session.setMaxInactiveInterval(30*60);
			//在session中存储用户名
			session.setAttribute("loginname", loginname);
			//跳转页面
			response.sendRedirect("success.jsp");
		}else{
			response.sendRedirect("login.jsp");
		}

	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		this.doGet(request, response);
	}

}
