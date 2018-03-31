package cn.com.systop.l08.listener;

import java.util.Vector;
public class UserList {
	private static Vector onlineUsers=new Vector();
	
	public static void addUser(String userName){
		onlineUsers.addElement(userName);
	}
	
	public static void removeUser(String userName){
		onlineUsers.removeElement(userName);
	}
	
	//获取在线用户数量
	public static int getUserCount(){
		return onlineUsers.size();
	}
	
	public static Vector getVector(){
		return onlineUsers;
	}
}

