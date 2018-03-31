using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机9任务1
{
    [Serializable]
    class Book:IComparable<Book>
    {
        string name;    //图书名称

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string author;  //作者

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        double price;   //价格

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Book(string n, string a, double p)
        {
            this.name = n;
            this.author = a;
            this.price = p;
        }
        public int CompareTo(Book book)
        {
            return this.price.CompareTo(book.price);
        }
    }
}
