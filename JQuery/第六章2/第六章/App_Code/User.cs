using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///User 的摘要说明
/// </summary>
public class User
{
	public User(string name,string password)
	{
        Name = name;
        Password = password;
	}
    public string Name { get; set; }
    public string Password { get; set; }
}
