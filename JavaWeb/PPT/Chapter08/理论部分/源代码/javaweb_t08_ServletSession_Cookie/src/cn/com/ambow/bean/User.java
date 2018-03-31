package cn.com.ambow.bean;

public class User {
	private String userName;
	private String userPass;

	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public String getUserPass() {
		return userPass;
	}

	public void setUserPass(String userPass) {
		this.userPass = userPass;
	}

	public User() {
		super();
	}

	public boolean isValidate() {
		return this.userName.equals("admin") && this.userPass.equals("admin");
	}
}
