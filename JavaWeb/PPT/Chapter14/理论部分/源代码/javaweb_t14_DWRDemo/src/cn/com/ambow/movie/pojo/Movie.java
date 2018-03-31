package cn.com.ambow.movie.pojo;

import java.sql.Date;

public class Movie {
	private int movieID=0;
	private String movieName="";
	private Date showTime=new Date(System.currentTimeMillis());
	private String director="";
	private int typeID=0;
	private String stardom="";
	private String region="";
	private String description="";
	private String image="";
	private double prive=0;
	private String typeName="";

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

	public Date getShowTime() {
		return showTime;
	}

	public void setShowTime(Date showTime) {
		this.showTime = showTime;
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

	public String getImage() {
		return image;
	}

	public void setImage(String image) {
		this.image = image;
	}

	public double getPrive() {
		return prive;
	}

	public void setPrive(double prive) {
		this.prive = prive;
	}

	public String getTypeName() {
		return typeName;
	}

	public void setTypeName(String typeName) {
		this.typeName = typeName;
	}

	public Movie(int id, String name, Date date, String director, int type) {
		super();
		this.movieID = id;
		this.movieName = name;
		this.showTime = date;
		this.director = director;
		this.typeID = type;
	}

	public Movie(int id, String name, Date date, String director, int type,
			String typeName) {
		super();
		this.movieID = id;
		this.movieName = name;
		this.showTime = date;
		this.director = director;
		this.typeID = type;
		this.typeName = typeName;
	}

	public Movie(int movieID, String movieName, Date showTime, String director,
			int typeID, String stardom, String region, String description,
			String image, double prive, String typeName) {
		super();
		this.movieID = movieID;
		this.movieName = movieName;
		this.showTime = showTime;
		this.director = director;
		this.typeID = typeID;
		this.stardom = stardom;
		this.region = region;
		this.description = description;
		this.image = image;
		this.prive = prive;
		this.typeName = typeName;
	}

	public Movie() {
		super();
	}

}
