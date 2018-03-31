package cn.com.ambow.movie.pojo;

public class Type {
	private int typeID=0;
	private String typeName="";

	public int getTypeID() {
		return typeID;
	}

	public void setTypeID(int typeID) {
		this.typeID = typeID;
	}

	public String getTypeName() {
		return typeName;
	}

	public void setTypeName(String typeName) {
		this.typeName = typeName;
	}

	public Type(int id, String name) {
		super();
		this.typeID = id;
		this.typeName = name;
	}

	public Type() {
		super();
	}

}
