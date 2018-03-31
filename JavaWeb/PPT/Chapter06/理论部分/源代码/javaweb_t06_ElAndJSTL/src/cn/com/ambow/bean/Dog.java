package cn.com.ambow.bean;

public class Dog {
	private String name;
	private String type;

	public Dog(String name, String type) {
		super();
		this.name = name;
		this.type = type;
	}

	public Dog() {
		super();
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "宠物名字：" + this.name + " 宠物类型：" + this.type;
	}

}
