using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 索引器_P26
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramGroup group = new ProgramGroup();
            Console.WriteLine("演员阵容");
            group[0] = new Player();
            group[0].Name = "甄子丹";
            group[0].Role = "叶问";
            group[1] = new Player();
            group[1].Name = "熊黛林";
            group[1].Role = "叶太太";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(group[i].Name);
            }
            Console.ReadLine();
        }
        class ProgramGroup
        {
            private Player[] players = new Player[2];

            public Player this[int index]
            {
                get { return players[index]; }
                set { players[index] = value; }
            }
            
        }
        class Player
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string role;

            public string Role
            {
                get { return role; }
                set { role = value; }
            }
            
        }
    }
}
