using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机1任务2
{
    class Program
    {
        public enum Invent
        {
            火药,印刷术,造纸术,指南针
        }
        static void Main(string[] args)
        {

            Console.WriteLine("中国古代四大发明是：");
            Console.WriteLine(Invent.火药);
            Console.WriteLine(Invent.印刷术);
            Console.WriteLine(Invent.造纸术);
            Console.WriteLine(Invent.指南针);
            Console.ReadLine();
        }
    }
}
