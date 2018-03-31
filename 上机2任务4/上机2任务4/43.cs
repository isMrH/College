using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机2任务4
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade grade = new Grade();
            grade.Gname="S1";
          
            Squad squad=new Squad();
          
            squad[0] = new Student();
            squad[0].Name = "S1T100";
            squad[0].Count = 25;
            
            squad[1] = new Student();
            squad[1].Name = "S1T101";
            squad[1].Count = 29;

            Console.WriteLine(grade.Gname + "的班级有");
            Console.WriteLine(squad[0].Name + "里有"+squad[0].Count+"人");
            Console.WriteLine(squad[1].Name + "里有" + squad[1].Count + "人");

            Console.ReadLine();
        }

        class Grade     //年级
        {
            private string gname;

            public string Gname
            {
                get { return gname; }
                set { gname = value; }
            }
          

        }
        class Squad
        {
            private string name;    //班级名称

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int count;

            public int Count
            {
                get { return count; }
                set { count = value; }
            }
            Student[] students = new Student[2];   //学生数组

            public Student this[int index]
            {
                get { return students[index]; }
                set { students[index] = value; }
            }
        }
    }
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
      
    }
}
