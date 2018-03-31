using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机6任务2
{
    class Student
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string sNumber;

        public string SNumber
        {
            get { return sNumber; }
            set { sNumber = value; }
        }
        private string sclass;

        public string Sclass
        {
            get { return sclass; }
            set { sclass = value; }
        }
        public Student(string n, string sn, string sc)
        {
            this.name = n;
            this.sNumber = sn;
            this.sclass = sc;
        }

    }
}
