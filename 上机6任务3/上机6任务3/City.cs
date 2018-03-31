using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机6任务3
{
    class City
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string province;

        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public City() { }
        public City(string n, string p, string c)
        {
            this.name = n;
            this.province = p;
            this.code = c;
        }
    }
}
