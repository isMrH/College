using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机6作业2
{
    class Player
    {
        string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Player(string num, string n)
        {
            this.number = num;
            this.name = n;
        }
      
    }
}
