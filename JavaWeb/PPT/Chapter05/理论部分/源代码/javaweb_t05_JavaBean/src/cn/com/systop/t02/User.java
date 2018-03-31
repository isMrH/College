package cn.com.systop.t02;

public class User {
	private String name="jack"; //私有属性
	
	public String getName() {	
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	public String welcome(){
		return "欢迎 "+this.getName()+" 访问JSP学习园地！";
	}
}
