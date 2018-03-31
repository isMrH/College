package cn.com.systop.l08.listener;


import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;
import javax.servlet.http.HttpSessionAttributeListener;
import javax.servlet.http.HttpSessionBindingEvent;
import javax.servlet.http.HttpSessionEvent;
import javax.servlet.http.HttpSessionListener;
import java.io.FileOutputStream;
import java.io.PrintWriter;
import java.util.Date;
import java.text.SimpleDateFormat;

public class OnlineListener implements HttpSessionAttributeListener, 	HttpSessionListener,ServletContextListener {
	//监听Http会话中的属性添加
	public void attributeAdded(HttpSessionBindingEvent e) {	
		UserList.addUser(String.valueOf(e.getValue())); //增加一个用户;
		print("session(" + e.getSession().getId() + ")增加属性"
			+ e.getName() + "，值为" + e.getValue());
	}
	
	//监听Http会话中的属性移除
	public void attributeRemoved(HttpSessionBindingEvent e) {
		UserList.removeUser(String.valueOf(e.getValue()));
		print("session(" + e.getSession().getId() + ")移除属性"
			+ e.getName() + "，值为" + e.getValue());
	}
	
	//监听Http会话中的属性更改操作
	public void attributeReplaced(HttpSessionBindingEvent e) {
		String oldValue=String.valueOf(e.getValue());//会话属性被替换之前的值
		String newValue=
			String.valueOf(e.getSession().getAttribute(e.getName()));
		UserList.removeUser(oldValue); 
		UserList.addUser(newValue);
		print("session(" + e.getSession().getId() + ")属性"
			+ e.getName() + "的值，由"+oldValue+"更改为" + newValue);
	}
	
	//Http会话的创建监听
	public void sessionCreated(HttpSessionEvent e) {
		print("创建新会话session("+e.getSession().getId()+")");
	}
	
	//Http会话的销毁监听
	public void sessionDestroyed(HttpSessionEvent e) {
		print("销毁会话session("+e.getSession().getId()+")");
	}
	
	//监听ServletContext创建
	public void contextInitialized(ServletContextEvent e) {
		print("ServletContext初始化......");
	}

	//监听ServletContext销毁
	public void contextDestroyed(ServletContextEvent e) {
		print("ServletContext被销毁......"); 
	}

	//将message字符串信息输出到txt文件
	private void print(String message) {	
		PrintWriter out = null;
		try {
			out = new PrintWriter(new 
					FileOutputStream("d:\\log.txt", true)); 
			out.println(new 
				SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(new Date())
					+ " " + message);
			out.close();
		}catch (Exception e){
			e.printStackTrace();
		}
	}
}
