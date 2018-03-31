
import java.sql.Connection;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
import java.sql.PreparedStatement;

/**
 *
 * @author Administrator
 */
public class InfoSql {
    //向数据库添加信息数据
    public int addInfo(UserInfo info)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="insert into UserInfo values(?,?,?,?,?)";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setString(1, info.getUserName());
            pstmt.setInt(2, info.getAge());
            pstmt.setString(3, info.getQualification());
            pstmt.setString(4, info.getPhone());
            pstmt.setString(5, info.getAddress());
            count=pstmt.executeUpdate();
        }catch(Exception ex){
            ex.printStackTrace();
        }finally{
            try{
                pstmt.close();
                con.close();
            }catch(Exception ex){
                ex.printStackTrace();
            }
        }
        return count;
    }
}
