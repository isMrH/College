using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWar
{
    class Eidolon:MagicAnimal
    {
        bool havePet;

        public bool HavePet
        {
            get { return havePet; }
            set { havePet = value; }
        }
        public Eidolon(string t, string a, bool h)
            : base(t, a)
        {
            this.havePet = h;
        }
        public override string Show()
        {
            string message = "种族-" + this.Type + "武器-" + this.Arm + "可以拥有坐骑";
            return message;
        }
    }
}
