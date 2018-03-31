using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Users 的摘要说明
/// </summary>
public class User
{
    //构造方法
	public User(string name)
	{
        Name = name; 
	}

    public string Name { get; set; }
}
