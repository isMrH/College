using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Student 的摘要说明
/// </summary>
public class Student
{
    public Student(int sid, string sname, string saddress)
    {
        this.SId = sid;
        this.SName = sname;
        this.SAddress = saddress;
    }
    public int SId { get; set; }
    public string SName{get;set;}
    public string SAddress { get; set; }

}
