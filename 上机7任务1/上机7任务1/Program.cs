using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7任务1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我国自主研发的主战水陆两栖坦克：");
            Ship_Tank tank = new Ship_Tank("63A","105毫米线膛炮");
            tank.Show();
            tank.Display();
            Console.ReadLine();
        }
    }
}
