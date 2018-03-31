/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package Exe;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;

/**
 *
 * @author Administrator
 */
public class MovieSql {
    public int addType(Type type)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="insert into Type values(?)";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setString(1, type.getTypeName());
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
    public Vector getAllType(){
        Vector typeVector=new Vector();
        Connection con=null;
        PreparedStatement pstmt=null;
        ResultSet rs=null;
        String sql="select * from type";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            rs=pstmt.executeQuery();
            while(rs.next()){
                Vector oneTypeVector=new Vector();
                oneTypeVector.add(rs.getInt(1));
                oneTypeVector.add(rs.getString(2));
                typeVector.add(oneTypeVector);
            }
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
        return typeVector;
    }
    public int getTypebyName(Type type){
        Vector typeVector=new Vector();
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        ResultSet rs=null;
        String sql="select * from type where typeName=?";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
             pstmt.setString(1, type.getTypeName());
            rs=pstmt.executeQuery();
            if(rs.next()){
                count=rs.getInt(1);
            }
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
    public int UpdateType(Type type)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="update Type set typeName=? where typeId=?";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setString(1, type.getTypeName());
            pstmt.setInt(2, type.getTypeID());
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
    public int DeleteType(Type type)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="delete from Type where typeId=?";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setInt(1, type.getTypeID());
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
    public int addMovie(Movie Movie)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="insert into movies(movieName,director,typeID,stardom,region,showtime,description,price) values(?,?,?,?,?,?,?,?)";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setString(1, Movie.getMovieName());
            pstmt.setString(2, Movie.getDirector());
            pstmt.setInt(3, Movie.getTypeID());
            pstmt.setString(4, Movie.getStardom());
            pstmt.setString(5, Movie.getRegion());
            pstmt.setString(6, Movie.getShowtime());
            pstmt.setString(7, Movie.getDescription());
            pstmt.setDouble(8, Movie.getPrice());
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
     public Vector getAllMovie(){
        Vector typeVector=new Vector();
        Connection con=null;
        PreparedStatement pstmt=null;
        ResultSet rs=null;
        String sql="select movieid,moviename,director,typename,stardom,region,showtime,description,price from movies inner join [type] on movies.typeID=[type].typeID ";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            rs=pstmt.executeQuery();
            while(rs.next()){
                Vector oneTypeVector=new Vector();
                oneTypeVector.add(rs.getInt(1));
                oneTypeVector.add(rs.getString(2));
                oneTypeVector.add(rs.getString(3));
                oneTypeVector.add(rs.getString(4));
                oneTypeVector.add(rs.getString(5));
                oneTypeVector.add(rs.getString(6));
                oneTypeVector.add(rs.getString(7));
                oneTypeVector.add(rs.getString(8));
                oneTypeVector.add(rs.getDouble(9));
                typeVector.add(oneTypeVector);
            }
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
        return typeVector;
    }
     public int DeleteMoive(Movie movie)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="delete from movies where movieID=?";
        try{
            con=Database.getcon();
            pstmt=con.prepareStatement(sql);
            pstmt.setInt(1, movie.getMovieID());
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
     public int UpdateMovie(Movie movie)
    {
        int count=0;
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="update movies set movieName=?,director=?,typeID=?,stardom=?,region=?,showtime=?,description=?,price=? where movieID=?";
        try{
            con=Database.getcon();
            pstmt=(PreparedStatement)con.prepareStatement(sql);
            pstmt.setString(1, movie.getMovieName());
            pstmt.setString(2, movie.getDirector());
            pstmt.setInt(3, movie.getTypeID());
            pstmt.setString(4, movie.getStardom());
            pstmt.setString(5, movie.getRegion());
            pstmt.setString(6, movie.getShowtime());
            pstmt.setString(7, movie.getDescription());
            pstmt.setDouble(8, movie.getPrice());
            pstmt.setInt(9, movie.getMovieID());
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
