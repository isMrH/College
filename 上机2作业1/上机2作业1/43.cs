using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机2作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Name = "《叶问2》";
            movie.Type="动作片";
            Console.WriteLine("正在上映的是" + movie.Type +movie.Name);
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
    }
}
