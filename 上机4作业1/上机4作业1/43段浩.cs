using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机4作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(17000, 900, 300);
            plane.Display();
            Battleplan bat = new Battleplan(22000, 2100, 1,"战术中程导弹","12.5毫米机炮");
    
            bat.Show();
            Console.ReadLine();
        }
    }
    class Aerostat
    {
        int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Aerostat(){}
        public Aerostat(int h, int s)
        {
            this.height = h;
            this.speed = s;
        }

    }
    class Plane : Aerostat
    {
        int people;

        public int People
        {
            get { return people; }
            set { people = value; }
        }
        public Plane() { }
        public Plane(int h,int s,int p) 
            :base(h,s)
        {
            this.people = p;
        }
        public void Display()
        {
            Console.WriteLine("这种新型飞机飞行高度"+this.Height+"米");
            Console.WriteLine("飞行时速" + this.Speed + "公里");
            Console.WriteLine("成员" + this.People + "人");
        }
    }
    class Battleplan : Plane
    {
        string mostlyArm;

        public string MostlyArm
        {
            get { return mostlyArm; }
            set { mostlyArm = value; }
        }
        string auxiliaryArm;

        public string AuxiliaryArm
        {
            get { return auxiliaryArm; }
            set { auxiliaryArm = value; }
        }
        public Battleplan() { }
        public Battleplan(int h, int s, int p, string m, string a)
            : base(h, s, p)
        {
            this.mostlyArm = m;
            this.auxiliaryArm = a;
        }
        public void Show()
        {
            Console.WriteLine("******************************");
            base.Display();
            Console.WriteLine("它的主武器是" + this.mostlyArm);
            Console.WriteLine("副武器是" + this.auxiliaryArm + "毫米机炮");

        }
                            
    }
}
