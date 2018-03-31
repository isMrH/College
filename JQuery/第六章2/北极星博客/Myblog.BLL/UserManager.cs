using System;
using System.Collections.Generic;
using System.Text;
using Myblog.Model;
using System.Data;
using Myblog.DAL;

namespace MyBlogBLL
{
   public static class UserManager
    {
          
       /// <summary>
       /// 添加用户
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       public static void Register(User user)
       {           
           UserService.AddUser(user);       
           
       }
       /// <summary>
       /// 判断用户名是否已重复注册
       /// </summary>
       /// <param name="loginId"></param>
       /// <returns></returns>
       public static bool IsUserNameRegister(string loginId)
       {
          User users = UserService.GetUserByLoginId(loginId );
           if (users != null)
               return true;
           else
           {               
               return false;
           }
       }
       /// <summary>
       /// 登录
       /// </summary>
       /// <param name="loginId">登录名</param>
       /// <param name="loginPwd">登录密码</param> 
       /// <returns></returns>
       public static bool Login(string loginId, string loginPwd)
       {
            int count= UserService.Login (loginId,loginPwd );
            if (count > 0)
                return true;
            else
                return false;              
         }
   }

}










