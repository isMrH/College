/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Administrator
 */
import java.sql.Connection;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;
public class MovieInfo {
    private int movieID;
    private String movieName;
    private String director;
    private int typeID;
    private String stardom;
    private String region;
    private String showTime;
    private String description;
    private Double price;

    public int getMovieID() {
        return movieID;
    }

    public void setMovieID(int movieID) {
        this.movieID = movieID;
    }

    public String getMovieName() {
        return movieName;
    }

    public void setMovieName(String movieName) {
        this.movieName = movieName;
    }

    public String getDirector() {
        return director;
    }

    public void setDirector(String director) {
        this.director = director;
    }

    public int getTypeID() {
        return typeID;
    }

    public void setTypeID(int typeID) {
        this.typeID = typeID;
    }

    public String getStardom() {
        return stardom;
    }

    public void setStardom(String stardom) {
        this.stardom = stardom;
    }

    public String getRegion() {
        return region;
    }

    public void setRegion(String region) {
        this.region = region;
    }

 

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }
    
    public String getShowTime() {
        return showTime;
    }

    public void setShowTime(String showTime) {
        this.showTime = showTime;
    }
 
    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public Vector getAllMovies(){
        Vector movieVector=new Vector();
        Connection con = null;
        PreparedStatement pstmt=null;
        ResultSet rs= null;
        String sql="Select * from movies";
        try{
            con=MovieDB.getCon();
            pstmt=con.prepareStatement(sql);
            rs=pstmt.executeQuery();
            while(rs.next()){
                Vector oneMovieVecotr = new Vector();
                oneMovieVecotr.add(rs.getInt(1));
                oneMovieVecotr.add(rs.getString(2));
                oneMovieVecotr.add(rs.getString(3));
                oneMovieVecotr.add(rs.getString(4));
                oneMovieVecotr.add(rs.getString(5));
                oneMovieVecotr.add(rs.getString(6));
                oneMovieVecotr.add(rs.getString(7));
                oneMovieVecotr.add(rs.getString(8));
                oneMovieVecotr.add(rs.getString(9));
                oneMovieVecotr.add(rs.getString(10));
                movieVector.add(oneMovieVecotr);
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
        return movieVector;
    }

  
}
