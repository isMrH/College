using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBookService.DAL;
using MyBook.Model;
namespace MyBookManager.BLL
{
    public class UserManager
    {
        UserService us = new UserService();
        //查询账户和密码是否输入正确
        public int LoginUser(string LoginId, string LoginPwd)
        {
            return us.LoginUser(LoginId, LoginPwd);
        }
         //查重
        public int IsHasInfo(string LoginId)
        {
            return us.IsHasInfo(LoginId);
        }
         //添加用户
        public int AddInfo(User user)
        {
            return us.AddInfo(user);
        }
         //获得在线用户
        public List<User> GetOnLine()
        {
            return us.GetOnLine();
        }
         
    }
}
