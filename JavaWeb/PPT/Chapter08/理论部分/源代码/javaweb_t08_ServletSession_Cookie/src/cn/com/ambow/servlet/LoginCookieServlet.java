package cn.com.ambow.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class LoginCookieServlet
 */
public class LoginCookieServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public LoginCookieServlet() {
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
		// TODO Auto-generated method stub
		request.setCharacterEncoding("utf-8");
		response.setCharacterEncoding("utf-8");
		response.setContentType("text/html;charset=utf-8");
		//接收客户端传来的数据
		String strName=request.getParameter("name");
		String strPass=request.getParameter("password");
		
		//如果想存储中文cookie。需要对字符进行编码
		strName=java.net.URLEncoder.encode(strName, "utf-8");
		strPass=java.net.URLEncoder.encode(strPass, "utf-8");
		
		//创建Cookie，并将数据存放在Cookie中
		Cookie cName=new Cookie("UserName",strName);
		Cookie cPass=new Cookie("Password",strPass);

		//创建永久Cookie
		cName.setMaxAge(60*10);
		cPass.setMaxAge(60*10);
		
		//将Cookie传送到客户端,此时生成的是临时Cookie。
		response.addCookie(cName);
		response.addCookie(cPass);
		
		//向客户端输出内容
		response.getWriter().print("登录成功<a href='cookieLogin/login.jsp'>返回登录页面</a>");
	}

}
