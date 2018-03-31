package cn.com.ambow.listener;

import javax.servlet.http.HttpSessionEvent;
import javax.servlet.http.HttpSessionListener;

public class SessinLifeCycleListener implements HttpSessionListener {

	public SessinLifeCycleListener() {
		System.out.println("创建了一个Listener");
	}

	@Override
	public void sessionCreated(HttpSessionEvent e) {
		// TODO Auto-generated method stub
		System.out.println("创建了一个session,id为：" + e.getSession().getId());
	}

	@Override
	public void sessionDestroyed(HttpSessionEvent e) {
		// TODO Auto-generated method stub
		System.out.println("销毁了一个session，id为：" + e.getSession().getId());
	}

}
