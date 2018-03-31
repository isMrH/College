using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7任务2
{
    class Player:IComparable<Player>
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player() { }
        public Player(string n,string c,double s)
        {
            this.name=n;
            this.country=c;
            this.score=s;
        }
        public int CompareTo(Player player)
        {
            return this.score.CompareTo(player.score);
        }
    }
}
