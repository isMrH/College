
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Administrator
 */
public class MovieType {
    private int typeid;
    private String typeName;

    public int getTypeid() {
        return typeid;
    }

    public void setTypeid(int typeid) {
        this.typeid = typeid;
    }

    public String getTypeName() {
        return typeName;
    }

    public void setTypeName(String typeName) {
        this.typeName = typeName;
    }
    public Vector getAllTypes(){
        Vector typeVector=new Vector();
        Connection con = null;
        PreparedStatement pstmt=null;
        ResultSet rs= null;
        String sql="Select * from type";
        try{
            con=MovieDB.getCon();
            pstmt=con.prepareStatement(sql);
            rs=pstmt.executeQuery();
            while(rs.next()){
                Vector oneTypeVecotr = new Vector();
                oneTypeVecotr.add(rs.getInt(1));
                oneTypeVecotr.add(rs.getString(2));
             
                typeVector.add(oneTypeVecotr);
            }
        }catch(Exception ex){
            ex.printStackTrace();
        }finally{
            try{
                rs.close();
                pstmt.close();
                con.close();
            }catch(Exception ex){
                ex.printStackTrace();
            }           
        }
        return typeVector;
    }
  
   public int EditType(MovieType type){
       int i=0;
       Connection con=null;
       PreparedStatement pstmt=null;
       String sql="update type set typename=? where typeid=?";
       try{
           con=MovieDB.getCon();
           pstmt=con.prepareStatement(sql);
           pstmt.setString(1,type.getTypeName());
           pstmt.setInt(2,type.getTypeid());    
           i=pstmt.executeUpdate();
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
       return i;
   }


    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MovieInfoFrame().setVisible(true);
            }
        });
    }
}
