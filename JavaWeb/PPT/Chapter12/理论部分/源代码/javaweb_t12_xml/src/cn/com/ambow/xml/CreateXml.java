package cn.com.ambow.xml;

import java.io.File;

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
import org.w3c.dom.Text;

public class CreateXml {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		DocumentBuilderFactory dbf=DocumentBuilderFactory.newInstance();
		DocumentBuilder db=null;
		try {
			db = dbf.newDocumentBuilder();
			/*
			 * 创建xml文件
			 */
			Document doc=db.newDocument();
			Element root=doc.createElement("root");
			Element parent=doc.createElement("parent");
			Element child1=doc.createElement("child");
			Attr attrN1=doc.createAttribute("attr1");
			attrN1.setNodeValue("value1");
			Attr attrN2=doc.createAttribute("attr2");
			attrN2.setNodeValue("value2");
			
			child1.setAttributeNode(attrN1);
			child1.setAttributeNode(attrN2);
			
			Element child2=doc.createElement("child");
			Text text=doc.createTextNode("这是文本内容");
			child2.appendChild(text);
			
			parent.appendChild(child1);
			parent.appendChild(child2);
			
			root.appendChild(parent);
			
			doc.appendChild(root);
			writeXML(doc,"new.xml");
			System.out.println("success");

		} catch (ParserConfigurationException e) {
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
			t.setOutputProperty(OutputKeys.INDENT, "yes");
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
