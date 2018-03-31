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
			//������¼�û���cookie
			Cookie cookie_name=new Cookie("loginname",loginname);
			//��������
			Cookie cookie_pwd=new Cookie("loginpwd",loginpwd);
			//���ù���ʱ��10��
			cookie_name.setMaxAge(10);
			cookie_pwd.setMaxAge(10);
			//��cookieд��ͻ���
			response.addCookie(cookie_name);
			response.addCookie(cookie_pwd);
			//����session
			HttpSession session=request.getSession();
			//����sessionʧЧʱ��30����
			session.setMaxInactiveInterval(30*60);
			//��session�д洢�û���
			session.setAttribute("loginname", loginname);
			//��תҳ��
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
