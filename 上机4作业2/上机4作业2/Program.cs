using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机4作业2
{
    class Program
    {
        static void Main(string[] args)
        {
            Articles art = new Articles("世界杯开幕式","布拉特","2010年6月11日","体坛周报");
            art.Show();
            Books book = new Books("三国演义","罗贯中","2010年6月11日","长江出版社");
            book.Show();
            Console.ReadLine();
        }
    }
    class Catalogue
    {
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public Catalogue() { }
        public Catalogue(string t, string a, string d)
        {
            this.title = t;
            this.author = a;
            this.date = d;
        }
        protected void Display()
        {
            Console.Write("标题：" + this.title);
            Console.Write("\t作者：" + this.author);
            Console.WriteLine("\t日期：" + this.date);
        }
    }
    class Articles:Catalogue
    {
        string newspaper;

        public string Newspaper
        {
            get { return newspaper; }
            set { newspaper = value; }
        }
        public Articles() { }
        public Articles(string t, string a, string d, string n)
            : base(t,a,d)
        {
            this.newspaper = n;
        }
        public void Show()
        {
            base.Display();
            Console.WriteLine("文章转载自"+this.newspaper);
        }
    }
    class Books : Catalogue
    {
        string book_Concern;

        public string Book_Concern
        {
            get { return book_Concern; }
            set { book_Concern = value; }
        }
        public Books() { }
        public Books(string t, string a, string d,string b)
            : base(t,a,d)
        {
            this.book_Concern = b;
        }
        public void Show()
        {
            Console.WriteLine("*******************************");
            base.Display();
            Console.WriteLine("出版单位："+this.book_Concern);
        }
    }
}
