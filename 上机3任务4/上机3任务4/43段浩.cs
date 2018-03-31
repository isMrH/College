using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3任务4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            double a = account.Area(5, 2.6);
            Console.WriteLine("三角形的面积是"+a);
            double r = 2.5;
            a = account.Area_Girth(ref r);
            Console.WriteLine("圆形的面积是"+a+"周长是"+r);
            Console.ReadLine();
        }
    }
    class Account
    {   
        public double Area(double d, double h)
        {
            double a = d * h / 2;
            return a;
        }
        public double Area_Girth(ref double r)
        {
            double a = r * r * 3.1415926;
            r = 2 * r * 3.1415926;
            return a;
        }  
    }
}
