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
       /// ����û�
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       public static void Register(User user)
       {           
           UserService.AddUser(user);       
           
       }
       /// <summary>
       /// �ж��û����Ƿ����ظ�ע��
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
       /// ��¼
       /// </summary>
       /// <param name="loginId">��¼��</param>
       /// <param name="loginPwd">��¼����</param> 
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










