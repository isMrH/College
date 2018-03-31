/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package com.handson;

/**
 *
 * @author Administrator
 */
public class Student {

    String idenID;  //身份证号
    String name;    //姓名
    String department;  //系部
    String classes; //班级
    public Student(String idenID,String name,String department,String classes)
    {
        this.idenID=idenID;
        this.name=name;
        this.department=department;
        this.classes=classes;
    }
    public String getName(){
        return name;
    }
    public String getIdenid(){
        return idenID;
    }
    public String getDepartment(){
        return department;
    }
    public String getClasses(){
        return classes;
    }
        static void setClasses(String trim) {
     
    }

    static void setDepartment(String trim) {
      
    }

    static void setIdenId(String trim) {
       
    }

    static void setName(String trim) {
   
    }
}
