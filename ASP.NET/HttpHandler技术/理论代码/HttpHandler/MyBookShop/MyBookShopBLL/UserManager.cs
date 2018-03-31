using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class UserManager
    {
        public static bool Login(string loginId, string loginPwd, out User validUser)
        {
            User user = UserService.GetUserByLoginId(loginId);
            if (user == null)
            {
                //�û��������� 
                validUser = null;
                return false;
            }

            if (user.LoginPwd == loginPwd)
            {
                validUser = user;
                return true;
            }
            else
            {
                //�������
                validUser = null;
                return false;
            }
        }

        public static bool Register(User user)
        {
            if (LoginIdExists(user.LoginId))
            {
                return false;
            }
            else
            {
                AddUser(user);
                return true;
            }
        }
        public static bool AdminLogin(string loginId, string loginPwd, out User validUser)
        {
            User user=UserService.GetAdminUserByLoginId(loginId);

            if (user == null)
            {
                //�û��������� 
                validUser = null;
                return false;
            }

            if (user.LoginPwd == loginPwd)
            {
                validUser = user;
                return true;
            }
            else
            {
                //�������
                validUser = null;
                return true;
            }
        }

        //��¶�˷���Ϊ�Ժ�� Ajax ������׼��
        public static bool LoginIdExists(string loginId)
        {
            return UserService.LoginIdExists(loginId);
        }

        
        public static IList<User> GetAllNormalUsers()
        {
            return UserService.GetAllNormalUsers();
        }

    }
}
