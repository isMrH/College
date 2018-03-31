package cn.com.ambow.bean;

public class Person {
	private String name = "孙夜话";
	private int age = 20;
	private Dog dog = new Dog("洒洒", "小狗");

	public Person(String name, int age, Dog dog) {
		super();
		this.name = name;
		this.age = age;
		this.dog = dog;
	}

	public Person() {
		super();
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public Dog getDog() {
		return dog;
	}

	public void setDog(Dog dog) {
		this.dog = dog;
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "姓名：" + this.name + "\t年龄：" + this.age + "\t宠物：" + this.dog;
	}

}
