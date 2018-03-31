/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Administrator
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
public class MovieDB {
    private final static String URL="jdbc:sqlserver://localhost:1433;databaseName=Movie";
    private final static String USERNAME="sa";
    private final static String PASSWORD="sa";
    public static Connection getCon(){
        Connection con = null;
        try{
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con=DriverManager.getConnection(URL,USERNAME,PASSWORD);
        }catch(SQLException ex){
            ex.printStackTrace();
        }catch(ClassNotFoundException ex){
            ex.printStackTrace();
        }
        return con;
    }
        
}

