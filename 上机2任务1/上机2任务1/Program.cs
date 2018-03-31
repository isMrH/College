using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机2任务1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "法拉利";
            car.Type = "跑车";
            Console.WriteLine("我的私家车是一辆"+car.Type);
            Console.WriteLine("品牌是"+car.Brand);
            Console.ReadLine();
        }
    }
}
