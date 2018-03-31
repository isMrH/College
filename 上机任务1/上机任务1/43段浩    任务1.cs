using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机任务1
{
    class 任务1
    {
        public enum Week
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("今天是" + Week.Monday);
            Console.ReadLine();
        }
    }
}
