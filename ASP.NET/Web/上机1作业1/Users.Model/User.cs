using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Users.Model
{
    public class User
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string loginID;

        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }
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
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
