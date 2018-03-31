package cn.com.systop.jspt06.entity;

public class Users {
	private int userID;//用户ID

	private String userName;//用户名

	private String userPass;//用户密码
	
	private String userIDCode;//身份证号码
	
	private String userTel;//电话号码
	
	private String userAddress;//地址
	
	private String userZip;//邮编

	public int getUserID() {
		return userID;
	}

	public void setUserID(int userID) {
		this.userID = userID;
	}

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

	public String getUserAddress() {
		return userAddress;
	}

	public void setUserAddress(String userAddress) {
		this.userAddress = userAddress;
	}

	public String getUserIDCode() {
		return userIDCode;
	}

	public void setUserIDCode(String userIDCode) {
		this.userIDCode = userIDCode;
	}

	public String getUserTel() {
		return userTel;
	}

	public void setUserTel(String userTel) {
		this.userTel = userTel;
	}

	public String getUserZip() {
		return userZip;
	}

	public void setUserZip(String userZip) {
		this.userZip = userZip;
	}
}
