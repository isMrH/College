package cn.com.ambow.listener;

import javax.servlet.http.HttpSessionAttributeListener;
import javax.servlet.http.HttpSessionBindingEvent;

public class SessionAttributeListener implements HttpSessionAttributeListener {

	@Override
	public void attributeAdded(HttpSessionBindingEvent e) {
		// TODO Auto-generated method stub
		System.out.println("id为" + e.getSession().getId()
				+ "的session添加了一个新的属性，名为：" + e.getName() + "值为：" + e.getValue());

	}

	@Override
	public void attributeRemoved(HttpSessionBindingEvent e) {
		// TODO Auto-generated method stub
		System.out.println("id为" + e.getSession().getId()
				+ "的session移除了一个属性，名为：" + e.getName() + "值为：" + e.getValue());
	}

	@Override
	public void attributeReplaced(HttpSessionBindingEvent e) {
		// TODO Auto-generated method stub
		System.out.println("id为"+e.getSession().getId()+"的session替换了一个已有的属性，名为："+e.getName()+"旧值为："+e.getValue()+"新值为："+e.getSession().getAttribute(e.getName()));
	}

}
