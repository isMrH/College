package com.systop.sql;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBCon {
	private final static String URL="jdbc:sqlserver://localhost:1433;databaseName=Users";
    private final static String USERNAME="sa";
    private final static String PASSWORD="sa";
    /**
     * 获得数据库连接方法
     */
    public static Connection getCon(){
        Connection con=null;
        try{
            //加载驱动
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //通过DriverManger获取数据库连接对象
            con=DriverManager.getConnection(URL, USERNAME, PASSWORD);
        }catch(Exception ex){
            ex.printStackTrace();
        }
        return con;
    }
}
