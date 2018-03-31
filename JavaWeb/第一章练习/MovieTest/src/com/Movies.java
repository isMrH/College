/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package com;



/**
 *
 * @author Administrator
 */
public class Movies {
  //编号
  private  int movieID;
  //电影名称
  private  String movieName;
  //导演
  private  String director;
  //类型id
  private  int typeID;
  //主演
  private  String stardom;
  //上映地区
  private  String region;
  //上映时间
  private  String showtime;
  //介绍
  private  String description;
  private  String moviespic;
  public String getMoviespic() {
	return moviespic;
}

public void setMoviespic(String moviespic) {
	this.moviespic = moviespic;
}

//价格
  private  double price;

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


    public String getShowtime() {
        return showtime;
    }

    public void setShowtime(String showtime) {
        this.showtime = showtime;
    }


    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }


    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

}
