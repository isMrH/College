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
		
		//��ȡҳ�洫�����Ĳ���
		String _pageNo = request.getParameter("pageNo");
		String _pageSize= request.getParameter("pageSize");
		//���ҳ�洫������pageNo��Ϊ�գ���ֱ��ת�����֣������ʾΪ��ҳ��Ĭ�ϸ�ֵ1
		int pageNo = 0;
		if(_pageNo != null){
			pageNo = Integer.parseInt(_pageNo);
		}else{
			pageNo = 1;
		}
		//���ҳ�洫������pageSize��Ϊ�գ���ֱ��ת�����֣�����ÿҳ��ʾĬ�ϸ�ֵ3������
		int pageSize = 0;
		if(_pageSize != null){
			pageSize = Integer.parseInt(_pageSize);
		}else{
			pageSize = 3;
		}
		//�õ��������
		int maxSize = dao.maxSize();
		
		//������������ÿҳ����������ܹ�ҳ��
		int maxPageNo = 0;
		if(maxSize%pageSize == 0){
			maxPageNo = maxSize/pageSize;
		}else{
			maxPageNo = maxSize/pageSize + 1;
		}
		
		//��У��pageNo��Ч��
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
