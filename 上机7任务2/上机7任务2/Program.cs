using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7任务2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> allPlayer = new List<Player>();
            Player p1 = new Player("刘  翔","中国",10.01);
            allPlayer.Add(p1);
            Player p2 = new Player("杜兰特","法国",10.11);
            allPlayer.Add(p2);
            Player p3 = new Player("罗伯斯","古巴",10.07);
            allPlayer.Add(p3);
            Player p4 = new Player("史冬鹏","中国",10.34);
            allPlayer.Add(p4);
            Player p5 = new Player("约翰逊","美国",10.12);
            allPlayer.Add(p5);
            allPlayer.Sort();

            Console.WriteLine("本届田径黄金联赛110米栏排名如下：");
            foreach(Player player in allPlayer)
            {
                Console.WriteLine(player.Name + "  " + player.Country + "  "+player.Score+"秒");
            }
            Console.ReadLine();

        }
    }
}
