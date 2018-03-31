using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机1任务3
{
    class Program
    {
        struct Player
        {
            public string name;
            public string subject;
            public void Diaplay()
            {
                Console.WriteLine("表演者："+name);
                Console.WriteLine("表演节目：" + subject);
            }
        }
        static void Main(string[] args)
        {
            Player player1, player2, player3;
            player1.name = "春哥";
            player1.subject = "歌曲《真的汉子》";
            player2.name = "凤姐";
            player2.subject = "小品《征婚》";
            player3.name = "犀利哥";
            player3.subject = "时装秀";
            player1.Diaplay();
            player2.Diaplay();
            player3.Diaplay();
            Console.Read();
        }
    }
}
