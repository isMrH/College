using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlog.Model
{
    public class User
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
        int qQ;

        public int QQ
        {
            get { return qQ; }
            set { qQ = value; }
        }
        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }



    }
}
