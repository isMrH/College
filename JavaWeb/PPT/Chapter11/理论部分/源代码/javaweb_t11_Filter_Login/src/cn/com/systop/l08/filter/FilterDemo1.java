package cn.com.systop.l08.filter;

import java.io.IOException;
import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;


public class FilterDemo1 implements Filter {

	private String targetEncoding;
    public FilterDemo1() {
    	
    }

	public void destroy() {

	}

	public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException, ServletException {
		request.setCharacterEncoding(targetEncoding);
		System.out.println("使用"+targetEncoding+"对请求进行编码过滤");
		chain.doFilter(request, response);
	}

	public void init(FilterConfig fConfig) throws ServletException {
		//获得配置filter中的参数值
		targetEncoding = fConfig.getInitParameter("encoding");
	}
}
