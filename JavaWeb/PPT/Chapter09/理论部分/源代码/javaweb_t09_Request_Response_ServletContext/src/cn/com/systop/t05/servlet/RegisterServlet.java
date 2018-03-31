package cn.com.systop.t05.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.com.systop.t05.javabean.UserInfo;

public class RegisterServlet extends HttpServlet {
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //设置请求字符编码格式
		request.setCharacterEncoding("gb2312");
		/*从请求获得数据*/
        String username = request.getParameter("username");
        String pwd = request.getParameter("pwd");
        String sex = request.getParameter("sex");
        String country = request.getParameter("country");
        String[] likes = request.getParameterValues("likes");
        String like = "";
        for (int i = 0; i < likes.length; i++) {
            like = like + likes[i] + "、";
        }
        String remark = request.getParameter("remark");
        
        //1.设置相应
        response.setContentType("text/html;charset=gb2312");
        PrintWriter out = response.getWriter();
        out.println("用户名：" + username + "<br>");
        out.println("密码：" + pwd + "<br>");
        out.println("性别：" + sex + "<br>");
        out.println("国家：" + country + "<br>");
        out.println("爱好：");
        for (int i = 0; i < likes.length; i++) {
            out.println(likes[i] + "、");
        }
        out.println("<br>备注：" + remark + "<br>");
        out.flush();
        out.close();
        
        //2.创建UserInfo类对象，对请求中数据进行封装
        /*UserInfo ui = new UserInfo();
        ui.setUsername(username);
        ui.setPwd(pwd);
        ui.setSex(sex);
        ui.setCountry(country);
        ui.setLikes(like);
        ui.setRemark(remark); 
        //把封装数据的UserInfo类对象，封装到request作用域中，名称为userinfo
        request.setAttribute("userinfo", ui);
        //请求转发
        request.getRequestDispatcher("success.jsp").forward(request, response);
        */
        //重定向
//        response.sendRedirect("success.jsp");
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		this.doGet(request, response);
	}
}
