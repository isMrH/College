using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机5作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("目前世界上正在研发的新能源概念汽车有太阳能和磁力两种：");
            Solar_Car solar = new Solar_Car();
            solar.Run();
            Magneticforce_Car mag = new Magneticforce_Car();
            mag.Run();
            Console.ReadLine();
        }
    }
    abstract class Car
    {
        public abstract void Run();
       
    }
    class Solar_Car : Car
    {
        public override void Run()
        {
            Console.WriteLine("太阳能汽车使用的是通过太阳能转化的电能来做汽车的燃料。");
        }
    }
    class Magneticforce_Car : Car
    {
        public override void Run()
        {
            Console.WriteLine("磁力汽车通过电能产生的磁力来驱动车辆。");
        }
    }
}
