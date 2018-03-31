package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class AddWare_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List _jspx_dependants;

  private javax.el.ExpressionFactory _el_expressionfactory;
  private org.apache.AnnotationProcessor _jsp_annotationprocessor;

  public Object getDependants() {
    return _jspx_dependants;
  }

  public void _jspInit() {
    _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
    _jsp_annotationprocessor = (org.apache.AnnotationProcessor) getServletConfig().getServletContext().getAttribute(org.apache.AnnotationProcessor.class.getName());
  }

  public void _jspDestroy() {
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;


    try {
      response.setContentType("text/html; charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n");
      out.write("<title>Insert title here</title>\r\n");
      out.write("<style type=\"text/css\">\r\n");
      out.write("*{\r\n");
      out.write("margin:0px;\r\n");
      out.write("padding:0px;\r\n");
      out.write("}\r\n");
      out.write("#Wapper{\r\n");
      out.write("width:1000px;\r\n");
      out.write("margin:0px auto;\r\n");
      out.write("height:auto;\r\n");
      out.write("}\r\n");
      out.write("#Main{\r\n");
      out.write("width:500px;\r\n");
      out.write("height:auto;\r\n");
      out.write("margin:0px auto;\r\n");
      out.write("}\r\n");
      out.write(".Title{\r\n");
      out.write("font-size:24px;\r\n");
      out.write("font-width:blod;\r\n");
      out.write("padding-left:20px;\r\n");
      out.write("margin-bottom:20px;\r\n");
      out.write("}\r\n");
      out.write("</style>\r\n");
      out.write("</head>\"\n");
      out.write("<body>\r\n");
      out.write("\r\n");
      out.write("<form name=\"form1\" method=\"post\" action=\"AddServlet\">\r\n");
      out.write("<div id=\"Wapper\">\r\n");
      out.write("\t<div id=\"Main\">\r\n");
      out.write("\t\t<div class=\"Title\">录入商品库存信息</div>\r\n");
      out.write("\t\t<div>商品名称：<input type=\"text\" /></div>\r\n");
      out.write("\t\t<div>商品类别：<input type=\"radio\" name=\"waretype\" value=\"1\"/>电器\r\n");
      out.write("\t\t\t\t\t  <input type=\"radio\" name=\"waretype\" value=\"2\"/>食品\r\n");
      out.write("\t\t\t\t\t  <input type=\"radio\" name=\"waretype\" value=\"3\"/>服装</div>\r\n");
      out.write("\t\t<div>商品数量：<input type=\"text\" /></div>\r\n");
      out.write("\t\t<div><input type=\"submit\" value=\"加入库存\"/><input type=\"reset\" value=\"重置\"/></div>\r\n");
      out.write("\t</div>\r\n");
      out.write("</div>\r\n");
      out.write("</form>\r\n");
      out.write("</body>\r\n");
      out.write("</html>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try { out.clearBuffer(); } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
