package cn.com.systop.JavaBean;
import java.sql.Connection;
import java.sql.DriverManager;

public class DBCon {
	private final static String URL="jdbc:sqlserver://localhost:1433;databaseName=WareDB";
    private final static String USERNAME="sa";
    private final static String PASSWORD="sa"; 
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
