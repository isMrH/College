package cn.com.systop.jspt06.entity;

public class Users {
	private int userID;//�û�ID

	private String userName;//�û���

	private String userPass;//�û�����
	
	private String userIDCode;//���֤����
	
	private String userTel;//�绰����
	
	private String userAddress;//��ַ
	
	private String userZip;//�ʱ�

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
