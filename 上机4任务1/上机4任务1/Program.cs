using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机4任务1
{
    class Program
    {
        static void Main(string[] args)
        {
            Galley galley = new Galley(50000,"核动力",21,"攻击潜艇","洲际导弹","鱼雷");
            galley.Show();
            Console.ReadLine();
        }
    }
    class Ship
    {
        private int weight;     //吨位

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string drive;   //动力

        public string Drive
        {
            get { return drive; }
            set { drive = value; }
        }   
        private int sailor;  //船员人数

        public int Sailor
        {
            get { return sailor; }
            set { sailor = value; }
        }

        public Ship() { }
        public Ship(int w, string d, int s)
        {
            this.weight = w;
            this.drive = d;
            this.sailor = s;
        }
    }
    class Galley : Ship
    {
        string type;    //军舰类型

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string mostlyArm;   //军舰主武器

        public string MostlyArm
        {
            get { return mostlyArm; }
            set { mostlyArm = value; }
        }
        string auxiliaryArm;    //军舰副武器

        public string AuxiliaryArm
        {
            get { return auxiliaryArm; }
            set { auxiliaryArm = value; }
        }

        public Galley(int w, string d, int s, string t, string marm, string aarm)
        {
            this.Weight = w;
            this.Drive = d;
            this.Sailor = s;
            this.type = t;
            this.mostlyArm = marm;
            this.auxiliaryArm = aarm;
        }
        public void Show()
        {
            Console.WriteLine("这是一种"+this.type);
            Console.WriteLine("吨位：" + this.Weight + "  动力：" + this.Drive + "  船员：" + this.Sailor + "人");
            Console.WriteLine("主武器：" + this.mostlyArm + "   副武器：" + this.auxiliaryArm);       
        }
    }
}
