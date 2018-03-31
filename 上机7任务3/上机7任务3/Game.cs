using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7任务3
{
    class Game
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int sell;

        public int Sell
        {
            get { return sell; }
            set { sell = value; }
        }
        double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        public Game() { }
        public Game(string n,int se,double sc)
        {
            this.name = n;
            this.sell = se;
            this.score = sc;
        }
    }
    class SellIComparer : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            return y.Sell.CompareTo(x.Sell);
        }
    }
    class ScoreIComparer : IComparer<Game>
    {
        public int Compare(Game x, Game y)
        {
            return y.Score.CompareTo(x.Score);
        }
    }
}
