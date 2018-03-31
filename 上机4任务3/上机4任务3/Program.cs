using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机4任务3
{
    class Program
    {
        static void Main(string[] args)
        {
            Eidolon eidolon = new Eidolon("魔法和物理攻击类型","弓箭",true);
            Console.WriteLine("魔兽争霸中的精灵属于"+eidolon.Type);
            Console.WriteLine("它们擅长使用的武器是"+eidolon.Arm);
            if (eidolon.IsHidSelf == true)
            {
                Console.WriteLine("它们的特点是可以隐身");
            }
            BlacklyEidolon bEidolon = new BlacklyEidolon("魔法和物理攻击类型","弓箭",true,false);
            Console.WriteLine("魔兽争霸中的精灵属于" + bEidolon.Type);
            Console.WriteLine("它们擅长使用的武器是" + bEidolon.Arm);
            if (bEidolon.IsHidSelf==true)
            {
                Console.WriteLine("它们的特点是隐身");
            }
            if (bEidolon.HasPet == true)
            {
                Console.WriteLine("强大的暗夜精灵可以拥有自己的坐骑");
            }
            else
            {
                Console.WriteLine("普通的暗夜精灵是没有坐骑的");
            }
            Console.ReadLine();
        }
    }
    class MagicAniaml
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
        public MagicAniaml() { }
        public MagicAniaml(string t, string a)
        {
            this.type = t;
            this.arm = a;
        }
    }
    class Eidolon : MagicAniaml
    {
        bool isHidSelf;

        public bool IsHidSelf
        {
            get { return isHidSelf; }
            set { isHidSelf = value; }
        }
        public Eidolon()
        {
            this.isHidSelf = true;
        }
        public Eidolon(string t,string a ,bool i)
            :base(t,a)
        {
            this.isHidSelf = i;
        }   
        
    }
    class BlacklyEidolon : Eidolon
    {
        bool hasPet;

        public bool HasPet
        {
            get { return hasPet; }
            set { hasPet = value; }
        }
        public BlacklyEidolon()
        {
            this.hasPet = false;
        }
        public BlacklyEidolon(string t, string a, bool i, bool h)
            : base(t, a, i)
        {
            this.hasPet = h;
        }
    }
}
