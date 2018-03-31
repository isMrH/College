package cn.com.abmow.ws.server;

public class MyService implements IServiceable {

	@Override
	public String sayHello(String name) {
		// TODO Auto-generated method stub
		return "Hello,你好,摩西摩西，"+name;
	}

	@Override
	public int add(int i, int j) {
		// TODO Auto-generated method stub
		return i+j;
	}

}
