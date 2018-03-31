using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顾客：我们想买一只宠物狗，请给介绍一下");
            Console.WriteLine("商家：这是藏獒");
            ZangAoDog zangAo = new ZangAoDog();
            zangAo.Act();
            Console.WriteLine("商家：这是京巴");
            JingBaDog jingBa = new JingBaDog();
            jingBa.Act();
            Console.ReadLine();
        }
    }
    class Dog     //父类
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Dog() { }
        public Dog(string t, int w, int h)
        {
            this.type = t;
            this.weight = w;
            this.height = h;
        }
    }
    class ZangAoDog : Dog 
    {
        public ZangAoDog()
        {
            this.Type = "藏獒";
            this.Weight = 30;
            this.Height = 60;
        }
        public void Act()
        {
            Console.WriteLine("这种狗非常凶猛，可以帮助牧民放养牛羊。");
        }
    }
    class JingBaDog : Dog 
    {
        public JingBaDog()
        {
            this.Type = "京巴";
            this.Weight = 6;
            this.Height = 20;
        }
        public void Act()
        {
            Console.WriteLine("这种狗非常乖巧可爱，被女性消费者所宠爱。");
        }
    }
}
