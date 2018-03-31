using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Model
{
    public class User
    {
        int bID;

        public int BID
        {
            get { return bID; }
            set { bID = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
