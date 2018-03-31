using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3_方法的重载_P38
{
    class Program
    {
        static void Main(string[] args)
        {
            Teleplay teleplay = new Teleplay();
            teleplay.Name = "《西游记》";
            Console.WriteLine("今天计划：");
            teleplay.Shoot("片头", "周杰伦");
            teleplay.Shoot("祸起观音院", 13, "聂远", "吴越","杨俊");
            Console.WriteLine("明天计划：");
            teleplay.Shoot("五指山", 12, "聂远", "吴越");
            Console.WriteLine("后天计划：");
            teleplay.Shoot("高老庄", 14, "聂远", "吴越", "蔵京生");
            Console.ReadLine();                                    

        }
    }
    class Teleplay
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Shoot(string title, string coryphaeus)
        {
            Console.WriteLine("拍摄"+name+"的"+title);
            Console.WriteLine("主唱：" + coryphaeus);
        }
        public void Shoot(string title, int index, string player1, string player2)
        {
            Console.WriteLine("拍摄" + name + "的第" + index + "集" + title);
            Console.WriteLine("主演：" + player1 + " " + player2);
        }
        public void Shoot(string title,int index,string player1, string player2,string player3)
        {
            Console.WriteLine("拍摄" + name + "的第" + index + "集" + title);
            Console.WriteLine("主演：" + player1 + " " + player2 + " " + player3);
        }
    }
}
