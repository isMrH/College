using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWar
{
    class People:MagicAnimal 
    {
        int relive;

        public int Relive
        {
            get { return relive; }
            set { relive = value; }
        }
        public People() { }
        public People(string t, string a, int r)
            : base(t, a)
        {
            this.relive = r;
        }
        public override string Show()
        {
            string message = "种族-" + this.Type + "武器-" + this.Arm + "拥有复活自己的部队的技能";
            return message;
        }
    }
}
