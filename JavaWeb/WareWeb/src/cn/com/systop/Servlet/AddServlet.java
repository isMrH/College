package cn.com.systop.Servlet;


import cn.com.systop.JavaBean.WareBean;
import cn.com.systop.sql.wareSql;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class AddServlet
 */
public class AddServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public AddServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String wareName=request.getParameter("wareName");
		int wareSort= Integer.parseInt(request.getParameter("wareSort")) ;
		int wareAmount =  Integer.parseInt(request.getParameter("wareAmount"));
		if(wareName==null||wareName.length()<0){
			wareName="";
		}

		try{
			wareSql ws=new wareSql();
			WareBean wareBean=new WareBean();
			wareBean.setWareName(wareName);
			wareBean.setWareSort(wareSort);
			wareBean.setWareAmount(wareAmount);

		}catch(Exception e){
			e.printStackTrace();
		}
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request,response);
	}

}