package cn.com.systop.l08.filter;

import java.io.IOException;
import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;


public class FilterDemo2 implements Filter {

    public FilterDemo2() {
        // TODO Auto-generated constructor stub
    }


	public void destroy() {
		// TODO Auto-generated method stub
	}


	public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException, ServletException {
		//获得客户的ip地址
		String ipAddress=request.getRemoteAddr();
		//截取ip地址中的前三个字符
		String ipBegin=ipAddress.substring(0, 3);//192.168.0.3
		//判断ip地址是不是192开头，如果不是不能登录
		if(!ipBegin.equals("127")){
			System.out.println("防止非ip地址为192开头的用户登录");
			request.setAttribute("errorip", "ip地址不正确，不能登录");
			request.getRequestDispatcher("login.jsp").forward(request, response);
			
		}
		else{
			chain.doFilter(request, response);
		}
	}

	public void init(FilterConfig fConfig) throws ServletException {
		// TODO Auto-generated method stub
	}

}
