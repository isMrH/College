using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7作业1
{
    interface ISaw  //锯子
    {
        void Display();
    }
    interface Iknives   //刀子
    {
        void Show();
    }
    class Yataghan:ISaw,Iknives
    {
        public void Display()
        {
            Console.WriteLine("瑞士军刀上的锯子可以锯断2毫米直径的铁丝。");
        }
        public void Show()
        {
            Console.WriteLine("瑞士军刀非常锋利，可以一刀砍断1毫米的钢板而不缺口。");
        }
    }
}
