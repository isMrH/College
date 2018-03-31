package cn.com;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;
/**
 * Servlet implementation class xmlServlet
 */
public class xmlServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public xmlServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.setContentType("text/html");
		response.setCharacterEncoding("UTF-8");
		PrintWriter out=response.getWriter();
		StringBuffer sBuff=new StringBuffer();
		sBuff.append("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">");
		sBuff.append("<HTML>");
		sBuff.append("<HEAD><TITLE>使用DOM解析XML</TITLE></HEAD>");
		sBuff.append("<BODY>");
		
		sBuff.append("</BODY></HTML>");
		System.out.print(sBuff.toString());
		out.write(sBuff.toString());
		parseXml(sBuff);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}
	
	private void parseXml(StringBuffer sBuff){
		DocumentBuilderFactory dbfactory=DocumentBuilderFactory.newInstance();
		DocumentBuilder dbuilder;
		try{
			dbuilder=dbfactory.newDocumentBuilder();
			Document dom=dbuilder.parse(getServletContext().getRealPath("users.xml"));
			Element root=dom.getDocumentElement();
			
			NodeList userNodes = root.getElementsByTagName("user");
			System.out.println(userNodes.getLength());
			if(userNodes.getLength()>0){
				sBuff.append("<TABLE border=\"1\">");
				sBuff.append("<CAPTION>用户列表</CAPTION>");
				sBuff.append("<TBODY>");
				sBuff.append("<TR><TH>编号</TH><TH>姓名</TH><TH>密码</TH><TH>角色</TH></TR>");
				for(int i=0;i<userNodes.getLength();i++){
					String id="";
					String name="";
					String pwd="";
					String role="";
					Element userElm=(Element) userNodes.item(i);
					id=userElm.getAttribute("id");
					NodeList childnodes=userElm.getChildNodes();
					for(int j=0;j<childnodes.getLength();j++){
						Node child = childnodes.item(j);
						if(child.getNodeType() == Node.ELEMENT_NODE){
							Element childElm = (Element)child;
							if("name".equals(childElm.getTagName())){
								name = childElm.getTextContent();
							}
							if("password".equals(childElm.getTagName())){
								pwd = childElm.getTextContent();
							}
							if("role".equals(childElm.getTagName())){
								role = childElm.getTextContent();
							}
						}
					}
					sBuff.append("<tr><td>"+id+"</td><td>"+name+"</td><td>"+pwd+"</td><td>"+role+"</td></tr>");
				}
				sBuff.append("</tbody></table>");
				}
			}catch(ParserConfigurationException e){
				e.printStackTrace();
			}catch(SAXException e){
				e.printStackTrace();
			}catch(IOException e){
				e.printStackTrace();
			}
	}

}
