package org.apache.jsp.AddMovie;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import com.Type;
import com.MySql;
import java.util.*;

public final class Movie_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
 String path=request.getContextPath(); 
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n");
      out.write("<title>Insert title here</title>\r\n");
      out.write("<style type=\"text/css\">\r\n");
      out.write("*{\r\n");
      out.write("\tmargin:0px auto;\r\n");
      out.write("\tpadding:0px;\r\n");
      out.write("\tlist-style:none;\r\n");
      out.write("\tfont-size:14px;}\r\n");
      out.write("#father{\r\n");
      out.write("\tmargin-top:5px;\r\n");
      out.write("\twidth:1004px;\r\n");
      out.write("\theight:auto;\r\n");
      out.write("\t}\r\n");
      out.write("#login{\r\n");
      out.write("\twidth:900px;\r\n");
      out.write("\theight:260px;\r\n");
      out.write("\tmargin-top:50px;\r\n");
      out.write("\t}\r\n");
      out.write("h1{\r\n");
      out.write("\tmargin-left:10px;\r\n");
      out.write("\tmargin-top:5px;}\r\n");
      out.write("#login li{\r\n");
      out.write("\theight:25px;\r\n");
      out.write("\t}\r\n");
      out.write("#loginleft{\r\n");
      out.write("\tfloat:left;\r\n");
      out.write("\ttext-align:right;\r\n");
      out.write("\twidth:120px;\r\n");
      out.write("\theight:260px;\r\n");
      out.write("\t}\r\n");
      out.write("#loginright{\r\n");
      out.write("\tfloat:left;\r\n");
      out.write("\twidth:500px;\r\n");
      out.write("\theight:300px;\r\n");
      out.write("\tmargin-left:15px;\r\n");
      out.write("\t}\r\n");
      out.write("#btnmit{\r\n");
      out.write("\tclear:both;\r\n");
      out.write("\tmargin-left:70px;\r\n");
      out.write("\twidth:80px;\r\n");
      out.write("\t}\t\r\n");
      out.write("span{\r\n");
      out.write("font-size:12px;}\r\n");
      out.write("</style>\r\n");
      out.write("\r\n");
      out.write("<link type=\"text/css\" rel=\"stylesheet\" href=\"");
      out.print(path );
      out.write("/cal/calendar-system.css\"/>\r\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(path );
      out.write("/cal/calendar.js\"></script>\r\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(path );
      out.write("/cal/calendar-en.js\"></script>\r\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(path );
      out.write("/cal/calShow.js\"></script> \r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write(" <div id=\"father\">\r\n");
      out.write("   <h1>添加电影DVD信息</h1>\r\n");
      out.write("   <form name=\"form2\" method=\"post\" action=\"doaction.jsp\">\r\n");
      out.write("   <div id=\"login\">\r\n");
      out.write("     <ul id=\"loginleft\">\r\n");
      out.write("       <li>电影名称</li>\r\n");
      out.write("       <li>导演</li>\r\n");
      out.write("       <li>主演</li>\r\n");
      out.write("       <li>电影分类</li>\r\n");
      out.write("       <li>电影出产地区</li>\r\n");
      out.write("       <li>电影上映时间</li>\r\n");
      out.write("       <li>电影图片</li>\r\n");
      out.write("       <li>电影定价</li>\r\n");
      out.write("       <li>电影简介</li>\r\n");
      out.write("     </ul >\r\n");
      out.write("     <ul id=\"loginright\">\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"moviename\"/></li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"director\"/></li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"statrdom\"/></li>\r\n");
      out.write("       <li><select name=\"typeid\">\r\n");
      out.write("            ");
 
                 MySql ms=new MySql();
                 List list=ms.search();
                 for(int i=0;i<list.size();i++)
                 {
                     Type types=(Type)list.get(i);
                 
      out.write("\r\n");
      out.write("                \t  <option value=\"");
      out.print(types.getTypeID() );
      out.write("\">\r\n");
      out.write("                \t   ");
      out.print(types.getTypeName() );
      out.write("\r\n");
      out.write("                \t </option>\r\n");
      out.write("                ");

                 }
       
            
      out.write("\r\n");
      out.write("            \r\n");
      out.write("          </select>\r\n");
      out.write("       </li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"conntry\"/></li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\"  name=\"showtime\" \r\n");
      out.write("       readonly=\"true\" onclick=\"calShow('showtime')\"/>\r\n");
      out.write("       <span style=\"color:red;\">&nbsp;*点击文本框弹出日历</span>\r\n");
      out.write("       </li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"picture\"/></li>\r\n");
      out.write("       <li><input type=\"text\" value=\"\" name=\"money\"/>\r\n");
      out.write("           \r\n");
      out.write("       \r\n");
      out.write("      </li>\r\n");
      out.write("       <li><textarea type=\"text\" value=\"\" name=\"content\"></textarea></li>\r\n");
      out.write("     </ul>\r\n");
      out.write("   </div>\r\n");
      out.write("     <div id=\"btnmit\"> <input type=\"submit\" value=\"提交\" id=\"btnmit\"/></div>\r\n");
      out.write("     </form>\r\n");
      out.write(" </div>\r\n");
      out.write("\r\n");
      out.write("</body>\r\n");
      out.write("</html>\r\n");
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
