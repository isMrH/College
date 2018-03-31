package cn.com.ambow.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import cn.com.ambow.bean.User;

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
		// TODO Auto-generated method stub
		//创建session对象
		HttpSession session=request.getSession();
		
		request.setCharacterEncoding("utf-8");
		String strUserName=request.getParameter("name");
		String strPass=request.getParameter("password");
		
		User ub=new User();
		ub.setUserName(strUserName);
		ub.setUserPass(strPass);
		
		if(ub.isValidate()){
			//验证通过
			session.setAttribute("user", ub);
			response.sendRedirect("sessionLogin/index.jsp");
		}else{
			response.sendRedirect("sessionLogin/login.html");
		}
	}

}
