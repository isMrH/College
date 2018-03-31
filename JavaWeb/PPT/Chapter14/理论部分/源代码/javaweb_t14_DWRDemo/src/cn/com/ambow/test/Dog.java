package cn.com.ambow.test;

public class Dog {

	private String name;
	private String category;
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getCategory() {
		return category;
	}
	public void setCategory(String category) {
		this.category = category;
	}
	
	public Dog() {
		// TODO Auto-generated constructor stub
	}
	public Dog(String name, String category) {
		super();
		this.name = name;
		this.category = category;
	}
	
	
}
