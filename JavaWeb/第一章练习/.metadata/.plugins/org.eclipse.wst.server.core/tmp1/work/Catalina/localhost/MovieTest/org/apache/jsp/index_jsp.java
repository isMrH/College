package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import com.MySql;
import com.Type;
import java.util.*;
import java.util.Vector;

public final class index_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List _jspx_dependants;

  static {
    _jspx_dependants = new java.util.ArrayList(1);
    _jspx_dependants.add("/ShowType.jsp");
  }

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

String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
request.removeAttribute("msg");

      out.write("\r\n");
      out.write("\r\n");
      out.write("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">\r\n");
      out.write("<html>\r\n");
      out.write("  <head>\r\n");
      out.write("    <base href=\"");
      out.print(basePath);
      out.write("\">\r\n");
      out.write("    \r\n");
      out.write("    <title>小型电影DVD在线销售系统</title>\r\n");
      out.write("    \r\n");
      out.write("\t<meta http-equiv=\"pragma\" content=\"no-cache\">\r\n");
      out.write("\t<meta http-equiv=\"cache-control\" content=\"no-cache\">\r\n");
      out.write("\t<meta http-equiv=\"expires\" content=\"0\">    \r\n");
      out.write("\t<meta http-equiv=\"keywords\" content=\"keyword1,keyword2,keyword3\">\r\n");
      out.write("\t<meta http-equiv=\"description\" content=\"This is my page\">\r\n");
      out.write("\t<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(path);
      out.write("/CSS/styles.css\">\r\n");
      out.write("\t<script type=\"text/javascript\" src=\"validate.js\"></script>\r\n");
      out.write("\t<script type=\"text/javascript\">\r\n");
      out.write("\t\tfunction doLogin(){\r\n");
      out.write("\t\t\tvar usr  = document.getElementById(\"usr\");\r\n");
      out.write("\t\t\tvar pwd  = document.getElementById(\"pwd\");\r\n");
      out.write("\t\t\tif (usr.value==\"\"){\r\n");
      out.write("\t\t\t\talert(\"用户名不能为空\");\r\n");
      out.write("\t\t\t\tusr.focus();\r\n");
      out.write("\t\t\t\treturn ;\r\n");
      out.write("\t\t\t}\r\n");
      out.write("\t\t\tif (pwd.value==\"\"){\r\n");
      out.write("\t\t\t\talert(\"密码不能为空\");\r\n");
      out.write("\t\t\t\tpwd.focus();\r\n");
      out.write("\t\t\t\treturn ;\r\n");
      out.write("\t\t\t}\r\n");
      out.write("\t\t\tdocument.forms[0].submit();\r\n");
      out.write("\t\t}\r\n");
      out.write("\t</script>\r\n");
      out.write("  </head>\r\n");
      out.write("  \r\n");
      out.write("  <body>\r\n");
      out.write("\r\n");
      out.write(" \t<div id=\"header\" class=\"center\">\r\n");
      out.write("\t  \t<img src=\"images/logo.jpg\" style=\"width:238px;height:66px;text-align:left;\"></img>\t\r\n");
      out.write("\t</div>\r\n");
      out.write("\t<div id=\"main\" class=\"center\">\r\n");
      out.write("\t\t  <div id=\"left\">\r\n");
      out.write("\t\t\t  \t<div id=\"search\">\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_title\">查找电影</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_content\" style=\"height:150px;\">\r\n");
      out.write("\t\t\t  \t\t\t&nbsp;\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_foot\"></div>\r\n");
      out.write("\t\t\t  \t</div>\r\n");
      out.write("\t\t\t  \t\r\n");
      out.write("\t\t\t  \t<div id=\"menu\">\r\n");
      out.write("\t\t\t\t\t<div class=\"dia_title\">电影分类</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_content2\" style=\"height:359px;\">\r\n");
      out.write("\t\t\t  \t\t\t<div class=\"list_item\" style=\"height:359px;overflow-y:scroll;\">\r\n");
      out.write("\t\t\t  \t\t\t\t");
      out.write("\r\n");
      out.write("\t\t\t  \t\t\t\t");
      out.write("\r\n");
      out.write("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">\r\n");
      out.write("\r\n");
      out.write(" \r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n");
      out.write("<title>小型电影DVD在线销售系统</title>\r\n");
      out.write("</head>\r\n");
      out.write("<body>\r\n");
      out.write("    ");
      out.write("\r\n");
      out.write("    ");

       //创建电影分类数据库访问类对象
       MySql ms = new MySql();
       //查询电影分类列表
       List list = new ArrayList();
       list = ms.search();
       for(int i=0;i<list.size();i++){
    	   Type type = (Type)list.get(i);
    
      out.write("\r\n");
      out.write("           <img src=\"images/arr.gif\">&nbsp;\r\n");
      out.write("           <a href=\"#\" class=\"menu\">");
      out.print(type.getTypeName() );
      out.write("</a><br><br>\r\n");
      out.write("     ");

       }
     
      out.write("\r\n");
      out.write("</body>\r\n");
      out.write("</html>");
      out.write("\r\n");
      out.write("\t\t\t  \t\t\t</div>\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_foot2\">&nbsp;</div>\r\n");
      out.write("\t\t\t  \t</div> <!-- end of menu -->\r\n");
      out.write("\t\t  \t</div> <!-- end of left --> \r\n");
      out.write("\t\t  \t<div id=\"middle\">\r\n");
      out.write("\t\t\t  \t\t<div class=\"m_title\">\r\n");
      out.write("\t\t\t  \t\t\t<img src=\"");
      out.print(path);
      out.write("/images/title_pic.jpg\" width=\"355\" height=\"175\">\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"bar\"></div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"m_content\" style=\"height:369px;width:340px;overflow-y:scroll;\">\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"m_foot\">\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t  \t</div><!-- end of middle --> \r\n");
      out.write("\t\t  \t <div id=\"right\">\r\n");
      out.write("\t\t\t  \t<div id=\"search\">\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_title\">电影DVD在线销售</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_content\" style=\"height:150px;padding:12px 2px 0 15px;\">\r\n");
      out.write("\t\t\t  \t\t\t\r\n");
      out.write("\t\t\t\t\t\t");
      out.write("\r\n");
      out.write("\t\t\t  \t\t\t\r\n");
      out.write("\t\t\t\t\t\t<div id=\"dvLogin\">\r\n");
      out.write("\t\t\t\t\t\t<form action=\"");
      out.print(path);
      out.write("/admin/doLogin.jsp\" method=\"post\">\r\n");
      out.write("\t\t\t\t\t\t<input type=\"hidden\" name=\"operate\" value=\"doLogin\">\r\n");
      out.write("\t\t\t  \t\t\t用户名：<input type=\"text\" name=\"userName\" id=\"usr\" style=\"width:60px;\" /> <br />\r\n");
      out.write("\t\t\t  \t\t\t密&nbsp;&nbsp;&nbsp;&nbsp;码：<input type=\"password\" name=\"passWord\" id=\"pwd\" style=\"width:60px;\" /> \r\n");
      out.write("\t\t\t  \t\t\t<br />\r\n");
      out.write("\t\t\t  \t\t\t<a href=\"");
      out.print(path);
      out.write("/admin/register.jsp\" class=\"a_button\">用户注册</a>&nbsp;\r\n");
      out.write("\t\t\t  \t\t\t<button class=\"button\" onclick=\"javascript:doLogin();\" style=\"width:40px;\">登录</button> <br />  \r\n");
      out.write("\t\t\t  \t\t\t&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n");
      out.write("\t\t\t  \t\t\t<img src=\"images/login.gif\" style=\"width:75px;\"></img>\r\n");
      out.write("\t\t\t  \t\t\t</form>\r\n");
      out.write("\t\t\t  \t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_foot\"></div>\r\n");
      out.write("\t\t\t  \t</div>\r\n");
      out.write("\t\t\t  \t<div id=\"menu\">\r\n");
      out.write("\t\t\t\t\t<div class=\"dia_title\">正在热卖</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_content2\" style=\"height:357px;\">\r\n");
      out.write("\t\t\t  \t\t\t<div class=\"list_item\">\r\n");
      out.write("\t\t\t  \t\t\t\t<img src=\"images/arr.gif\">&nbsp; <a href=\"#\" class=\"menu\"></a>\r\n");
      out.write("\t\t\t  \t\t\t</div>\r\n");
      out.write("\t\t\t  \t\t\t\r\n");
      out.write("\t\t\t  \t\t</div>\r\n");
      out.write("\t\t\t  \t\t<div class=\"dia_foot2\">&nbsp;</div>\r\n");
      out.write("\t\t\t  \t</div> <!-- end of menu -->\r\n");
      out.write("\t\t  \t</div> <!-- end of right --> \r\n");
      out.write("      </div> <!-- end of main -->\r\n");
      out.write("\t  <div id=\"footer\" class=\"center\">\r\n");
      out.write("\t  </div>\r\n");
      out.write("  \t    \r\n");
      out.write("  </body>\r\n");
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
