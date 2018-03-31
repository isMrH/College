using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7任务1
{
    abstract class Tank //坦克类，抽象类
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string arm;

        public string Arm
        {
            get { return arm; }
            set { arm = value; }
        }
        public abstract void Show();
    }
    interface IShip //船的接口
    {
        void Display();
    }
    class Ship_Tank : Tank, IShip
    {
        public override void Show()
        {
            Console.WriteLine("型号为"+this.Type+"的坦克装备的武器是"+this.Arm);
        }
        public void Display()
        {
            Console.WriteLine("此型号坦克为水陆两栖坦克，可以在水中以14公里/小时的速度行驶");
        }
        public Ship_Tank() { }
        public Ship_Tank(string t, string a)
        {
            this.Type = t;
            this.Arm = a;
        }

    }
}
