using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 联系人
{
    class LinkMan
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int type;
       
        public int Type
        {
          get { return type; }
          set { type = value; }
        }
    }
}
