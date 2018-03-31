using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上级2任务3
{
    class Program
    {
        static void Main(string[] args)
        {
            Squad squad = new Squad();
            squad.Name = "S1T101";
            squad[0] = new Student();
            squad[0].Name = "奔跑哥";
            squad[0].Sex = "男";
            squad[0].Age = 20;
            squad[1] = new Student();
            squad[1].Name = "凤姐";
            squad[1].Sex = "女";
            squad[1].Age = 22;

            Console.WriteLine(squad.Name+"班中有学生");
            Console.WriteLine(squad[0].Name + "     " + squad[0].Sex + "     " + squad[0].Age + "岁");
            Console.WriteLine(squad[1].Name + "     " + squad[1].Sex + "     " + squad[1].Age + "岁");
            Console.ReadLine();
        }
    }
}
