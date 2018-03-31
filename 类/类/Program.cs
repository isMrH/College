using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类
{
    class Program
    {
        static void Main(string[] args)
        {
            student stu = new student();
            stu.name = "张三丰";
            stu.age = 18;
            stu.hellow();
        }
    }
    class student
    {
        public string name;
        public int age;
        public void hellow()
        {
            Console.WriteLine(name+":Hellow!I am "+age+" years old.");
            Console.ReadLine();
        }
    }
}
