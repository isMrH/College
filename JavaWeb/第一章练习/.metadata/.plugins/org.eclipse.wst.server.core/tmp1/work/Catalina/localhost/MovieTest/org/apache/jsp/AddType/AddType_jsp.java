package org.apache.jsp.AddType;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class AddType_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      response.setContentType("text/html; charset=utf-8");
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
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n");
      out.write("<title>添加电影类型</title>\r\n");
      out.write("<style type=\"text/css\">\r\n");
      out.write("*{\r\n");
      out.write("   margin:0px auto;\r\n");
      out.write("   padding:0px;\r\n");
      out.write("}\r\n");
      out.write(".father{\r\n");
      out.write("   width:1004px;\r\n");
      out.write("   height:700px;\r\n");
      out.write("   border:1px solid #c1c1c1;\r\n");
      out.write("}\r\n");
      out.write(".title{\r\n");
      out.write("   padding-top:25px;\r\n");
      out.write("   background-color:#c1c1c1;\r\n");
      out.write("   height:60px;\r\n");
      out.write("}\r\n");
      out.write(".content{\r\n");
      out.write("   padding-top:20px;\r\n");
      out.write("   text-align:center;\r\n");
      out.write("}\r\n");
      out.write("</style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("<form name=\"fm1\" method=\"post\" action=\"doaction.jsp\">\r\n");
      out.write("  <div class=\"father\">\r\n");
      out.write("    <div class=\"title\"><h2>添加电影分类信息</h2></div>\r\n");
      out.write("    <div class=\"content\">\r\n");
      out.write("            电影分类名称：<input type=\"text\" name=\"typename\"></input><br/><br/>\r\n");
      out.write("            <input type=\"submit\" value=\"提交\"></input> <br/><br/><br/>\r\n");
      out.write("           <img alt=\"\" src=\"/MovieTest/images/title_pic.jpg\">\r\n");
      out.write("    </div>\r\n");
      out.write("  </div>\r\n");
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
