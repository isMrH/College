package systop.register;

public class UserRegisterBean {
	private String username;
	private String userpassword;
	
	public UserRegisterBean(){
		this.username = "";
		this.userpassword = "";
	}

	public String getUsername(){
		return username;
	}

	public void setUsername(String username){
		this.username = username;
	}
	
	public String getUserpassword(){
		return userpassword;
	}

	public void setUserpassword (String userpassword){
		this.userpassword=userpassword;
	}

	public boolean validaty(){
		boolean allright = true;
		if(username.equals("")){
			allright = false;
		}
		if(userpassword.equals("")||userpassword.length()>12||
			userpassword.length()<6){
			allright = false;
		}
		return allright;
	}
}
