package com.systop.l07.controller;

import java.util.ArrayList;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.systop.l07.util.ContactBean;
import com.systop.l07.util.PageBean;

public class PageServlet extends javax.servlet.http.HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws javax.servlet.ServletException, java.io.IOException {
		
		response.setContentType("text/html");
		
		try {
			PageBean pagebean = new PageBean();
			ContactBean contact = new ContactBean();
			
			int pagecount = pagebean.countPage();// 获取总共的页数
			String topage = request.getParameter("topage");// 获取当前的页码
			//页码有效区域的判断
			if (topage == null) {
				topage = "1";
			}
			if (Integer.parseInt(topage) > pagecount) { // 判断当前的页码是否越界,如果是的话就进行处理
				topage = String.valueOf(pagecount);
			} else if (Integer.parseInt(topage) <= 0) {
				topage = "1";
			}
			
			ArrayList news = contact.getData(topage, pagecount);
			
			request.getSession().setAttribute("pagecount", pagecount);
			request.getSession().setAttribute("showpage", topage);// 将当前的页码返回给页面,这样进行计算
			request.getSession().setAttribute("news1", news);
			
			response.sendRedirect("page.jsp");
			
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	public void doPost(HttpServletRequest request, HttpServletResponse response)

	throws javax.servlet.ServletException, java.io.IOException {
		doGet(request, response);
	}
}
