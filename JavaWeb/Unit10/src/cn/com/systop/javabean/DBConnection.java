package cn.com.systop.javabean;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DBConnection {
	private final static String URL="jdbc:sqlserver://localhost:1433;databaseName=MesDB";
    private final static String USERNAME="sa";
    private final static String PASSWORD="sa"; 
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