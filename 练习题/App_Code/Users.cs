using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Users 的摘要说明
/// </summary>
public class Users
{
	public static readonly List<User> UserList = new List<User>();
    static Users(){
        UserList.Add(new User("admin"));
        UserList.Add(new User("wang"));
    }
}
