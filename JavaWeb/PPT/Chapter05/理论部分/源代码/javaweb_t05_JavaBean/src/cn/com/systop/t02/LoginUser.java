package cn.com.systop.t02;
/**
 * 登录用户JavaBean
 * @author Administrator
 *
 */
public class LoginUser {
	/*** 以下是属性 ***/
	private String userName;      //用户名      
	private String userPassword;  //密码
	private boolean vip;		  //是否是VIP
	/*** 以上是属性 ***/
	/*** 以下是属性对应的get/set方法 ***/
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
	public boolean isVip() {
		return vip;
	}
	public void setVip(boolean vip) {
		this.vip = vip;
	}
	/*** 以上是属性对应的get/set方法 ***/
}
