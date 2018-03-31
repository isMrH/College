package cn.com.systop.t02;

public class UserRegisterBean {
	private String userName;//用户名
	private String userPassword;//密码

	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public String getUserPassword() {
		return userPassword;
	}

	public void setUserPassword(String userPassword) {
		this.userPassword = userPassword;
	}

	public String toString(){
		return "欢迎"+this.getUserName()+"注册成功，密码为："+this.getUserPassword();
	}
}
