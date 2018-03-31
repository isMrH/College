using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机5任务2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Attack();
            Wraith wra = new Wraith();
            wra.Attack();
            Hag hag = new Hag();
            hag.Attack();
            Console.ReadLine();
        }
    }
    class Hero
    {
        public virtual void Attack()
        {
            Console.WriteLine("暗黑破坏神中各个角色有什么特点？");
        }
    }
    class Wraith:Hero
    {
        public override void Attack()
        {
            Console.WriteLine("死灵法师等级10");
            Console.WriteLine("每次攻击对怪物的伤害是120并附带虚弱效果");
          
        }
    }
    class Hag : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("女巫等级10");
            Console.WriteLine("每次攻击对怪物的伤害是80并附带50的冰冻伤害");

        }
    }
}
