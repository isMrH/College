using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBlog.Model
{
    public class Users
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string loginId;

        public string LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }
        string loginPwd;

        public string LoginPwd
        {
            get { return loginPwd; }
            set { loginPwd = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string qq;

        public string Qq
        {
            get { return qq; }
            set { qq = value; }
        }
        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

    }
}
