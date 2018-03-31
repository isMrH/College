package cn.com.ambow.servlet;

import java.io.IOException;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class ShopCartServlet
 */
public class ShopCartServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public ShopCartServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String itemID = request.getParameter("ItemID");
		int buyCount = Integer.parseInt(request.getParameter("ShopCount"));
		HttpSession session = request.getSession();
		// session.setAttribute(itemID, buyCount);
		HashMap shopCart = null;
		if (session.getAttribute("SelectedGoods") == null) {
			shopCart = new HashMap();
		} else {
			shopCart = (HashMap) session.getAttribute("SelectedGoods");
		}
		// 如果该商品存在则在已有的基础上增加
		if (shopCart.containsKey(itemID)) {
			int oldCount = (Integer) shopCart.get(itemID);
			shopCart.put(itemID, oldCount + buyCount);
		} else {
			shopCart.put(itemID, buyCount);
		}

		session.setAttribute("SelectedGoods", shopCart);
		if (itemID.equals("1")) {
			response.sendRedirect("shopCart/book.html");
		} else {
			response.sendRedirect("shopCart/toy.html");
		}
	}

}
