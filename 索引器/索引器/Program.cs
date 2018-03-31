using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramGroup group = new ProgramGroup();
            Player[] name = new Player[2];

            name[0] = new Player();
            name[0].Name = "甄子丹";
            name[0].Role = "叶问";

            name[1] = new Player();
            name[1].Name = "熊黛林";
            name[1].Role = "叶太太";
            group.Player = name;

            Console.WriteLine("演员阵容");
            for (int i = 0; i < group.Player.Length; i++)
            {
                Console.WriteLine(group.Player[i].Name);
            }
            Console.ReadLine();

        }
    }
    class ProgramGroup //剧组类
    {
        private Player[] player;    //演员组数字段

        public Player[] Player
        {
            get { return player; }
            set { player = value; }
        }
    }
    class Player //演员类
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string role;    //扮演角色字段

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
