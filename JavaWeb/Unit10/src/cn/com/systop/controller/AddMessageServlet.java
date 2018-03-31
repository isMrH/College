package cn.com.systop.controller;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import cn.com.systop.javabean.*;
import cn.com.systop.oper.ManageMes;
/**
 * Servlet implementation class AddMessageServlet
 */
public class AddMessageServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public AddMessageServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String messName=request.getParameter("messName");
		String title=request.getParameter("title");
		String content = request.getParameter("content");
		if(messName==null||messName.length()<0){
			messName="";
		}
		if(title==null||title.length()<0){
			title="";
		}
		if(content==null||content.length()<0){
			content="";
		}
		try{
			ManageMes mm=new ManageMes();
			MessageBean mesBean=new MessageBean();
			mesBean.setContent(content);
			mesBean.setMessName(messName);
			mesBean.setTitle(title);
			SimpleDateFormat dateFormat=new SimpleDateFormat("yyyy-MM-dd");
			Calendar ct=Calendar.getInstance();
			
			mesBean.setMessDate(java.sql.Date.valueOf(String.valueOf(dateFormat.format(ct.getTime()))));
			mm.addMessage(mesBean);
			RequestDispatcher requestDispatcher=request.getRequestDispatcher("/viewMess");
			requestDispatcher.forward(request, response);
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
