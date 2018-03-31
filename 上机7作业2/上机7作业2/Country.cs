using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7作业2
{
    class Country
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int goldPlate;

        public int GoldPlate
        {
            get { return goldPlate; }
            set { goldPlate = value; }
        }
        int medal;

        public int Medal
        {
            get { return medal; }
            set { medal = value; }
        }
        public Country() { }
        public Country(string n, int g, int m)
        {
            this.name = n;
            this.goldPlate = g;
            this.medal = m;
        }
    }
}
