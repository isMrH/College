using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3任务1
{
    class Program
    {
        static void Main(string[] args)
        {
            VeryAct act1 = new VeryAct();
            VeryAct act2 = new VeryAct(2);
            Console.ReadLine();
        }
    }
    class VeryAct
    {
        private int index;  //节目期数

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public VeryAct()
        {
            Console.WriteLine("第1期非常男女正式开始");
        }
        public VeryAct(int i)
        {
            this.index = 1;
            Console.WriteLine("第"+i+"期非常男女正式开始");
        }
    }
}
