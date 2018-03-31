package cn.com.ambow.xml;

import java.io.File;
import java.io.IOException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Attr;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.w3c.dom.Text;
import org.xml.sax.SAXException;

public class ReadXML {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		DocumentBuilderFactory dbf=DocumentBuilderFactory.newInstance();
		try {
			DocumentBuilder db=dbf.newDocumentBuilder();
			
			/*
			 * 遍历，修改xml文件。
			 */
			Document doc=db.parse(new File("students.xml")); //读取，可以遍历，可以修改
			//Element root=doc.getDocumentElement();//可以得到根节点后，依次遍历。
			/*
			 * 遍历
			 */
			NodeList list=doc.getElementsByTagName("student");//也可以定位到特定节点进行遍历。
			for(int i=0;i<list.getLength();i++){
				Element student=(Element) list.item(i);
				Element studentName=(Element) student.getElementsByTagName("name").item(0);
				String strName=studentName.getFirstChild().getNodeValue();
				System.out.println("name:"+strName);
				Element studentAge=(Element) student.getElementsByTagName("age").item(0);
				String strAge=studentAge.getFirstChild().getNodeValue();
				System.out.println("age:"+strAge);
				System.out.println("-------------------");
				//可以执行修改。
				if(i==0){
					studentName.getFirstChild().setNodeValue("KAKA");
					studentAge.getFirstChild().setNodeValue("28");
				}
			}

			writeXML(doc,"students_new.xml"); //修改之后需要保存xml文档。
			
		} catch (ParserConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
			catch (SAXException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
		
		
		
	}
	
	public static void writeXML(Document doc,String fileName){
		TransformerFactory tf=TransformerFactory.newInstance();
		try {
			Transformer t=tf.newTransformer();
			DOMSource source=new DOMSource(doc);
			StreamResult result=new StreamResult(new File(fileName));
			t.setOutputProperty(OutputKeys.ENCODING, "utf-8");
//			t.setOutputProperty(OutputKeys.INDENT, "no");
			t.transform(source, result);
		} catch (TransformerConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (TransformerException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
