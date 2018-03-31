using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机2任务2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu=new Student();
            stu.Name="奔跑哥";
            stu.Sex="男";
            stu.Age=20;

            Console.WriteLine("我的同学是" + stu.Name);
            Console.WriteLine("性别：" + stu.Sex);
            Console.WriteLine("年龄：" + stu.Age);
            Console.ReadLine();
        }
    }
}
