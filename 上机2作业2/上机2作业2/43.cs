using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机2作业2
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Name = "《叶问2》";
            movie.Type = "动作片";
            Console.WriteLine("正在上映的是" + movie.Type + movie.Name);
            Console.WriteLine("主要演员：");

            movie[0] = new Player();
            movie[0].Name = "甄子丹";
            movie[0].Sex = "（男）";
            movie[0].Role = "叶问";

            movie[1] = new Player();
            movie[1].Name = "熊黛林";
            movie[1].Sex = "（女）";
            movie[1].Role = "叶太太";

            Console.WriteLine(movie[0].Name+movie[0].Sex+"扮演"+movie[0].Role);
            Console.WriteLine(movie[1].Name + movie[1].Sex + "扮演" + movie[1].Role);

            Console.ReadLine();
        }
    }
    class Movie
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        Player[] players = new Player[2];

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
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
