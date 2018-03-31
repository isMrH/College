using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3任务3
{
    class Program
    {
        static void Main(string[] args)
        {
            VeryAct act1 = new VeryAct();
            act1.Play("凤姐", "征婚广告");
            act1.Play(6,"装醒哥","小品","困不是我的错");
            VeryAct act2 = new VeryAct(2);
            act2.Play("春哥", "真的汉子");
            act2.Play("奔跑哥","小品","穿越生死线");
            Console.ReadLine();
        }
    }
    class VeryAct
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string act;

        public string Act
        {
            get { return act; }
            set { act = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public VeryAct()
        {
            Console.WriteLine("第1期非常男女正式开始...");
        }
        public VeryAct(int i)
        {
            this.index = i;
            Console.WriteLine("第"+i+"期非常男女正式开始...");
        }
        public void Play(string name, string act)
        {
            Console.WriteLine("下一个节目是"+name+"带来的"+act);
        }
        public void Play(int age,string name, string type, string act)
        {
            Console.WriteLine("下一个节目是"+age+"岁的表演者" + name + "带来的" + type + "：" + act);
        }
        public void Play(string name,string type,string act)
        {
            Console.WriteLine("下一个节目是"+name+"带来的"+type+"："+act);
        }
    }
}
