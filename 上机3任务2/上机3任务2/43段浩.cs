using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3任务2
{
    class Program
    {
        static void Main(string[] args)
        {
            VeryAct act1 = new VeryAct();
            act1.Play("凤姐","征婚广告");
            
            VeryAct act2 = new VeryAct(2);
            act2.Play("春哥","真的汉子");
            Console.ReadLine();
        }
    }
    class VeryAct
    {
        private int index;      //节目期数

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private string name;   //表演者

        public string Name
        {
          get { return name; }
          set { name = value; }
        }
        private string act; //节目名称

        public string Act
        {
          get { return act; }
          set { act = value; }
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
    }
   
}
