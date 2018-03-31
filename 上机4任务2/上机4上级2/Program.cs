using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机4上级2
{
    class Program
    {
        static void Main(string[] args)
        {
            Music music = new Music("二泉映月","酱油哥","乐曲","二胡");
            music.Show();
            Song s = new Song("一无所有", "凤姐", "歌曲", "少女时代");
            s.Show();
            Console.ReadLine();
        }
    }
    class Act
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string performer;

        public string Performer
        {
            get { return performer; }
            set { performer = value; }
        }
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        protected void Display()
        {
            Console.WriteLine("下面请欣赏"+type+name);
            Console.WriteLine("表演者："+performer);
        }
        public Act(string n,string p,string t)
        {
            this.name=n;
            this.performer=p;
            this.type=t;
        }
    }
    class Music : Act 
    {
        string music_Instrument;

        public string Music_Instrument
        {
            get { return music_Instrument; }
            set { music_Instrument = value; }
        }
        public Music(string n, string p, string t, string m)
             :base(n,p,t)
        {
            this.music_Instrument = m;
        }
        public void Show()
        {
            base.Display();
            Console.WriteLine("演奏乐器："+this.music_Instrument);
        }
    }
    class Song : Act
    {
        string dance_Band;

        public string Dance_Band
        {
            get { return dance_Band; }
            set { dance_Band = value; }
        }
        public Song(string n, string p, string t, string d)
            : base(n, p, t)
        {
            this.dance_Band = d;
        }
        public void Show()
        {
            base.Display();
            Console.WriteLine("伴舞："+dance_Band);
        }
    }

}
