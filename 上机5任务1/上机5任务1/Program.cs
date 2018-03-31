using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机5任务1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("海军航母编队中的各种军舰的战斗方式：");
            Aircraft_Carrier carrier = new Aircraft_Carrier();
            carrier.Action();
            Chaser chaser = new Chaser();
            chaser.Action();
            Console.ReadLine();
        }
    }
    abstract class Warship
    {
        public abstract void Action();
    }
    
    class Aircraft_Carrier : Warship
    {
        public override void Action()
        {
            Console.WriteLine("航空母舰使用舰载机进行远程攻击");
            Console.WriteLine("航空母舰的防守主要依靠编队的其他船只，本身也配备了一些导弹和联装火炮进行防护。");
        }
    }
    class Chaser:Warship 
    {
        public override void  Action()
        {
            Console.WriteLine("驱逐舰依靠自身的导弹、鱼雷和火炮进行攻击和防护");
        }

    }
}
