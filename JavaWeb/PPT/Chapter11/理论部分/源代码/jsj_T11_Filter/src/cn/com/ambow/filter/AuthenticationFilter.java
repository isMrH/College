package cn.com.ambow.filter;

import java.io.IOException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;

/**
 * Servlet Filter implementation class AuthenticationFilter
 */
public class AuthenticationFilter implements Filter {

	/**
	 * Default constructor.
	 */
	public AuthenticationFilter() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see Filter#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
	}

	/**
	 * @see Filter#doFilter(ServletRequest, ServletResponse, FilterChain)
	 */
	public void doFilter(ServletRequest request, ServletResponse response,
			FilterChain chain) throws IOException, ServletException {
		// TODO Auto-generated method stub
		// place your code here
		
		//1.请求多个页面时的过滤问题
		HttpSession session = ((HttpServletRequest) request).getSession();
		System.out.println("验证登录身份");
		if (session.getAttribute("user") == null) {
			((HttpServletResponse) response).sendRedirect("login.html");
		} else {
			// pass the request along the filter chain
			chain.doFilter(request, response);
		}
		
		//2.修改配置后的解决方案
//		HttpServletRequest requ=(HttpServletRequest)request;
//		HttpServletResponse resp=(HttpServletResponse)response;
//		HttpSession session=requ.getSession();
//		String strServletContextPath=session.getServletContext().getContextPath();
//		
//		if(session.getAttribute("user")==null){
//			resp.sendRedirect(strServletContextPath+"/login.html");
//		}else{
//			chain.doFilter(request, response);
//		}
	}

	/**
	 * @see Filter#init(FilterConfig)
	 */
	public void init(FilterConfig fConfig) throws ServletException {
		// TODO Auto-generated method stub
	}

}
