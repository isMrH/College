package cn.com.systop.jspt04.entity;

public class Type {
	private int typeID;//电影分类ID

	private String typeName;//电影分类名称

	//属性的getter、setter方法
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
}
