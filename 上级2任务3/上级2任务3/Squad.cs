using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上级2任务3
{
    class Squad
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        Student[] students = new Student[2];
        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index]=value;}
        }
    }
}
