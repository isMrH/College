package cn.com.systop.jspt05.entity;

public class Movies {
	private int movieID;// ��ӰID

	private String movieName;// ��Ӱ����

	private String director;// ����

	private String stardom;// ����

	private int typeID;// ��Ӱ���ͣ�������0������1ϲ�硢2���顢3�ƻá�4�ֲ���5���顢6ð�ա�7���֡�8���ա�9���ǡ�10��ʷ��11����

	private String region;// ��Ӱ��������

	private String showtime;// ��Ӱ��ӳʱ��

	private String description;// ��Ӱ���

	private String image;// ��ӰͼƬ

	private double price;// ��Ӱ����

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
