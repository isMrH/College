package com.systop.DB;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBCon {
	private final static String URL="jdbc:sqlserver://localhost:1433;databaseName=BookDB";
    private final static String USERNAME="sa";
    private final static String PASSWORD="sa";
    /**
     * ������ݿ����ӷ���
     */
    public static Connection getCon(){
        Connection con=null;
        try{
            //��������
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //ͨ��DriverManger��ȡ���ݿ����Ӷ���
            con=DriverManager.getConnection(URL, USERNAME, PASSWORD);
        }catch(Exception ex){
            ex.printStackTrace();
        }
        return con;
    }
}