package org.apache.jsp.AddMovie;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import com.Type;
import com.MySql;
import java.util.*;

public final class AddMovie_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n");
      out.write("<title>Insert title here</title>\r\n");
      out.write("<style type=\"text/css\">\r\n");
      out.write("*{\r\n");
      out.write("   margin:0px auto;\r\n");
      out.write("   padding:0px;\r\n");
      out.write("   list-style:none;\r\n");
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
      out.write("   margin-left:300px;\r\n");
      out.write("}\r\n");
      out.write(".content li{\r\n");
      out.write("   height:40px;\r\n");
      out.write("   line-hight:30px;\r\n");
      out.write("}\r\n");
      out.write("#left{\r\n");
      out.write("   float:left;\r\n");
      out.write("   text-align:right;\r\n");
      out.write("}\r\n");
      out.write("#right{\r\n");
      out.write("   margin-left:10px;\r\n");
      out.write("   float:left;\r\n");
      out.write("}\r\n");
      out.write("#clear{\r\n");
      out.write("   clear:both;\r\n");
      out.write("}\r\n");
      out.write("#foot{}\r\n");
      out.write("</style>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("<form method=\"post\" action=\"dotest.jsp\">\r\n");
      out.write("   <div class=\"father\">\r\n");
      out.write("      <div class=\"title\"><h2>添加电影DVD信息</h2></div>\r\n");
      out.write("      <div class=\"content\">\r\n");
      out.write("         <ul id=\"left\">\r\n");
      out.write("               <li>电影名称：</li>\r\n");
      out.write("               <li>导演：</li>\r\n");
      out.write("               <li>主演：</li>\r\n");
      out.write("               <li>电影分类：</li>\r\n");
      out.write("               <li>电影出产地区：</li>\r\n");
      out.write("               <li>电影上映时间：</li>\r\n");
      out.write("               <li>电影简介：</li>\r\n");
      out.write("               <li>电影图片：</li>\r\n");
      out.write("               <li>电影定价：</li>\r\n");
      out.write("         </ul>\r\n");
      out.write("         <ul id=\"right\">\r\n");
      out.write("              <li><input type=\"text\" name=\"movieName\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"director\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"stardom\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li><select name=\"typeid\" style=\"width:155px;\">\r\n");
      out.write("                   ");

                      MySql ms = new MySql();
                      List list = ms.search();
                      for(int i=0;i<list.size();i++){
                    	  Type type=(Type)list.get(i);
                   
      out.write("\r\n");
      out.write("                      <option value=\"");
      out.print(type.getTypeID() );
      out.write('"');
      out.write('>');
      out.print(type.getTypeName() );
      out.write("</option>\r\n");
      out.write("                    ");

                      }
                    
      out.write("\r\n");
      out.write("                  </select></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"region\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"showtime\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li id=\"text\"><textarea name=\"description\" style=\"width:150px;height:30px\"></textarea></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"image\" style=\"width:150px;\"></input></li>\r\n");
      out.write("              <li><input type=\"text\" name=\"price\" style=\"width:150px;\"></input></li>\r\n");
      out.write("         </ul>\r\n");
      out.write("      </div>\r\n");
      out.write("      <div id=\"clear\"></div>\r\n");
      out.write("      <div id=\"foot\"><input type=\"submit\" value=\"提交\"></input></div>\r\n");
      out.write("   </div>\r\n");
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
