package cn.com.ambow.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class AreaServlet
 */
public class AreaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public AreaServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String type=request.getParameter("type");
		if("province".equals(type)){
			//请求的是省份的数据
			try {
//				Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
//				Connection conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=movie","sa", "sa");
				Class.forName("com.mysql.jdbc.Driver");
				Connection conn=DriverManager.getConnection("jdbc:mysql://localhost:3306/movie","root", "root");
				Statement stmt=conn.createStatement();
				ResultSet rs=stmt.executeQuery("select * from area where parentid=0");
				response.setContentType("text/html;charset=utf-8");
				PrintWriter out=response.getWriter();
				out.println("<select id='selectProvince' onchange='fun2(this.value)'>");
				out.println("	<option value='0'>--请选择省份--</option>");
				while(rs.next()){
					out.println("	<option value='"+rs.getInt(1)+"'>"+rs.getString(2)+"</option>");
				}
				out.println("</select>");
				rs.close();
				stmt.close();
				conn.close();
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
		}else if("city".equals(type)){
			//请求的是城市的数据
			String pid=request.getParameter("pid");
			try {
//				Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
//				Connection conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=movie","sa", "sa");
				Class.forName("com.mysql.jdbc.Driver");
				Connection conn=DriverManager.getConnection("jdbc:mysql://localhost:3306/movie","root", "root");
				Statement stmt=conn.createStatement();
				ResultSet rs=stmt.executeQuery("select * from area where parentid="+pid);
				response.setContentType("text/html;charset=utf-8");
				PrintWriter out=response.getWriter();
				out.println("<select id='selectCity'>");
				out.println("	<option value='0'>--请选择城市--</option>");
				while(rs.next()){
					out.println("	<option value='"+rs.getInt(1)+"'>"+rs.getString(2)+"</option>");
				}
				out.println("</select>");
				rs.close();
				stmt.close();
				conn.close();
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
