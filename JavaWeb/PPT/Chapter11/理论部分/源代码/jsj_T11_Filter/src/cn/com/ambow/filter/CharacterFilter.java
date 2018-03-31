package cn.com.ambow.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;


public class CharacterFilter implements Filter {

	public CharacterFilter(){
		System.out.println("FilterInstance");
	}
	
	@Override
	public void destroy() {
		// TODO Auto-generated method stub
		System.out.println("FilterDestroy");
	}

	@Override
	public void doFilter(ServletRequest request, ServletResponse response,
			FilterChain chain) throws IOException, ServletException {
		// TODO Auto-generated method stub
		System.out.println("FilterDoFilter");
		request.setCharacterEncoding("utf-8");
		System.out.println("将请求的字符集设置为UTF-8");
		//继续调用过滤器的下一环，如果没有下一环，则直接转交到请求的资源。
		//如果不调用过滤器链，则请求停止。
		chain.doFilter(request, response);
	}

	@Override
	public void init(FilterConfig arg0) throws ServletException {
		// TODO Auto-generated method stub
		System.out.println("FilterInitial");
	}

	
	
	

}
