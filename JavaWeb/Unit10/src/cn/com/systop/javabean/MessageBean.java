package cn.com.systop.javabean;

public class MessageBean {
	private Integer messID;
	private String messName;
	private String title;
	public Integer getMessID() {
		return messID;
	}
	public void setMessID(Integer messID) {
		this.messID = messID;
	}
	public String getMessName() {
		return messName;
	}
	public void setMessName(String messName) {
		this.messName = messName;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getContent() {
		return content;
	}
	public void setContent(String content) {
		this.content = content;
	}
	public java.sql.Date getMessDate() {
		return messDate;
	}
	public void setMessDate(java.sql.Date messDate) {
		this.messDate = messDate;
	}
	private String content;
	private java.sql.Date messDate;
}
