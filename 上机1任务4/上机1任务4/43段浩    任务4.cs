using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机1任务4
{
    class Program
    {
        struct Account
        { 
            const double pi = 3.1415926;
            public double r;
            public void Diaplay()
            {
                double S=pi*r*r;
                Console.WriteLine("圆的面积是:"+S);
            }
        }
        static void Main(string[] args)
        {
            Account a;
            Console.WriteLine("请输入圆的半径：");
            a.r = Convert.ToDouble(Console.ReadLine());
            
            a.Diaplay();
            Console.ReadLine();
        }
    }
}
