using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7作业1
{
    class Program
    {       
        static void Main(string[] args)
        {
            Yataghan yata = new Yataghan();
            Console.WriteLine("瑞士军刀的特点是：");
            yata.Display();
            yata.Show();
            Console.ReadLine();
        }
    }

}
