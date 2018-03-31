package cn.com.systop.jspt05.entity;

public class Movies {
	private int movieID;// 电影ID

	private String movieName;// 电影名称

	private String director;// 导演

	private String stardom;// 主演

	private int typeID;// 电影类型，包括：0动作、1喜剧、2爱情、3科幻、4恐怖、5剧情、6冒险、7音乐、8惊险、9传记、10历史、11其他

	private String region;// 电影出产地区

	private String showtime;// 电影上映时间

	private String description;// 电影简介

	private String image;// 电影图片

	private double price;// 电影定价

	public Movies() {
		
	}
	
	public Movies(String movieName, String director,
			String stardom, int typeID, String region, String showtime,
			String description, double price) {
		this.movieName = movieName;
		this.director = director;
		this.stardom = stardom;
		this.typeID = typeID;
		this.region = region;
		this.showtime = showtime;
		this.description = description;
		this.price = price;
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

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public String getDirector() {
		return director;
	}

	public void setDirector(String director) {
		this.director = director;
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

	public String getStardom() {
		return stardom;
	}

	public void setStardom(String stardom) {
		this.stardom = stardom;
	}

	public int getTypeID() {
		return typeID;
	}

	public void setTypeID(int typeID) {
		this.typeID = typeID;
	}
}
