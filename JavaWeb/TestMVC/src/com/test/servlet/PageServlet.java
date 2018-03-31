package com.test.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.test.dao.PageDao;

/**
 * Servlet implementation class PageServlet
 */
public class PageServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public PageServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		this.doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		PageDao dao = new PageDao();
//		List list = dao.findAll();
//		request.setAttribute("list", list);
//		request.getRequestDispatcher("/show.jsp").forward(request, response);
		
		//获取页面传过来的参数
		String _pageNo = request.getParameter("pageNo");
		String _pageSize= request.getParameter("pageSize");
		//如果页面传过来的pageNo不为空，则直接转成数字，否则表示为首页，默认赋值1
		int pageNo = 0;
		if(_pageNo != null){
			pageNo = Integer.parseInt(_pageNo);
		}else{
			pageNo = 1;
		}
		//如果页面传过来的pageSize不为空，则直接转成数字，否则每页显示默认赋值3条数据
		int pageSize = 0;
		if(_pageSize != null){
			pageSize = Integer.parseInt(_pageSize);
		}else{
			pageSize = 3;
		}
		//拿到最大行数
		int maxSize = dao.maxSize();
		
		//根据行数除于每页的条数算出总共页数
		int maxPageNo = 0;
		if(maxSize%pageSize == 0){
			maxPageNo = maxSize/pageSize;
		}else{
			maxPageNo = maxSize/pageSize + 1;
		}
		
		//先校验pageNo有效性
		if(pageNo <=0){
			pageNo = 1;
		}
		if(pageNo > maxPageNo){
			pageNo = maxPageNo;
		}
		
		List list  = dao.findPage(pageNo, pageSize);
		request.setAttribute("list", list);
		request.setAttribute("pageNo", pageNo);
		request.setAttribute("maxPageNo", maxPageNo);
		request.setAttribute("pageSize", pageSize);
		request.getRequestDispatcher("/pageShow.jsp").forward(request, response);
	}

}
