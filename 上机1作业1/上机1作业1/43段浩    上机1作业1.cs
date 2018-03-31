using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机1作业1
{
    class Program
    {
        public enum Constellation
        {
            白羊座,金牛座,双子座,巨蟹座,狮子座,处女座,天秤座,天蝎座,射手座,摩羯座,水瓶座,双鱼座
        }
        static void Main(string[] args)
        {
            Console.WriteLine("十二星座是：");
            Console.WriteLine(Constellation.白羊座);
            Console.WriteLine(Constellation.处女座);
            Console.WriteLine(Constellation.金牛座);
            Console.WriteLine(Constellation.巨蟹座);
            Console.WriteLine(Constellation.摩羯座);
            Console.WriteLine(Constellation.射手座);
            Console.WriteLine(Constellation.狮子座);
            Console.WriteLine(Constellation.双鱼座);
            Console.WriteLine(Constellation.双子座);
            Console.WriteLine(Constellation.水瓶座);
            Console.WriteLine(Constellation.天秤座);
            Console.WriteLine(Constellation.天蝎座);
            Console.ReadLine();
        }
    }
}
