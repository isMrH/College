using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWar
{
    abstract class MagicAnimal
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string arm;

        public string Arm
        {
            get { return arm; }
            set { arm = value; }
        }
        public MagicAnimal() { }
        public MagicAnimal(string t, string a)
        {
            this.type = t;
            this.arm = a;
        }
        public abstract string Show();
    }
}
