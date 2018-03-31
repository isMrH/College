<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Collections.Generic;
public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

       context.Response.ContentType = "application/json";  

        List<Student> students = new List<Student>();
        Student student1 = new Student(1, "张三", "石家庄");
        Student student2 = new Student(2, "李四", "北京");

        students.Add(student1);
        students.Add(student2);
        string json = students.ToJson();
        context.Response.Write(json);
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}