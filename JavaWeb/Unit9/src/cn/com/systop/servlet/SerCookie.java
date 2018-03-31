package cn.com.systop.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class SerCookic
 */
public class SerCookie extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public SerCookie() {
        super();
        // TODO Auto-generated constructor stub
    }
    
    public void init(ServletConfig config) throws ServletException{
    	super.init(config);
    }
    public void service(HttpServletRequest request,HttpServletResponse response) throws IOException{
    	response.setCharacterEncoding("GBK");
    	Cookie thisCookie=null;
    	PrintWriter out=response.getWriter();
    	Cookie[] cookies = request.getCookies();
    	out.print("<html><body>");
    	out.println("<span style'color:red;'>&nbsp&nbsp&nbsp;"+"ServletCookie</span><br/><br/>");
    	out.println("欢迎来到ServlerCookie!<br/><br/>");
    	if(cookies==null){
    		thisCookie=new Cookie("CookieCount","1");
    		out.println("您是第一次浏览本页！");
    	}
    	else{
    		for(int i=0;i<cookies.length;i++){
    			thisCookie=cookies[i];
    			if(thisCookie.getName().equals("CookieCount")){
    				break;
    			}
    		}
    		int cookieCount=Integer.parseInt(thisCookie.getValue());
    		cookieCount++;
    		out.println("您在近10秒内访问过本页，你一共访问了"+cookieCount+"次本页面");
    		thisCookie.setValue(String.valueOf(cookieCount));
    	}
    	thisCookie.setMaxAge(10);
    	response.addCookie(thisCookie);
    	out.println("</body></html>");
    }    	
    
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
