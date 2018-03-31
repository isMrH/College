package cn.com.ambow.test;

public class Person {
	/**
	 * 无参方法
	 * 
	 * @return
	 */
	public String hello() {
		return "Hello World!";
	}

	/**
	 * 带一个参数的方法
	 * 
	 * @param name
	 * @return
	 */
	public String sayHello(String name) {
		return "hello," + name;
	}

	/**
	 * 带两个参数的方法
	 * 
	 * @param i
	 * @param j
	 * @return
	 */
	public int add(int i, int j) {
		return i + j;
	}

	/**
	 * 自定义类型做返回值
	 * 
	 * @return
	 */
	public Dog saleDog() {
		Dog d = new Dog();
		d.setName("旺财");
		d.setCategory("笨狗");
		return d;
	}

	/**
	 * 自定义类型做参数
	 * 
	 * @param d
	 * @return
	 */
	public String feedDog(Dog d) {
		return d.getName() + "说：我是：" + d.getCategory() + ",谢谢饲养！";
	}
}
