package cn.com.ambow.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.codehaus.xfire.XFire;
import org.codehaus.xfire.XFireFactory;
import org.codehaus.xfire.client.XFireProxyFactory;
import org.codehaus.xfire.service.Service;
import org.codehaus.xfire.service.binding.ObjectServiceFactory;

/**
 * Servlet implementation class TestServlet
 */
public class TestServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public TestServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		Service serviceModel=new ObjectServiceFactory().create(IServiceable.class);
		XFire xfire=XFireFactory.newInstance().getXFire();
		XFireProxyFactory factory=new XFireProxyFactory(xfire);
		String serviceUrl="http://localhost:8080/javaweb_t15_0101_WebServiceXFireServer/services/MyService";
		IServiceable client=null;
		client=(IServiceable) factory.create(serviceModel, serviceUrl);
		
		//调用服务器端方法
		String name=new String(request.getParameter("UserName").getBytes("iso-8859-1"),"utf-8");
		String msg=client.sayHello(name);
		response.setContentType("text/html;charset=utf-8");
		response.getWriter().println(msg);
		int rst=client.add(100, 100);
		response.getWriter().println("<br/>"+rst);

	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		this.doGet(request, response);
	}

}
