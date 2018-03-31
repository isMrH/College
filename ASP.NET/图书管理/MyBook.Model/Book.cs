using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBook.Model
{
    public class Book
    {
        public int Id { get; set; }//编号
        public string Title { get; set; }//书名
        public string Author { get; set; } //作者
        public int CategoryId { get; set; } //
        public double UnitPrice { get; set; } //单价
        public int Clicks { get; set; } //单击率
        public int PublisherId { get; set; } //
        public DateTime PublishDate { get; set; } //出版日期
        public string ISBN { get; set; } //ISBN码
        public int WordsCount { get; set; } //字数
        public string ContentDescription { get; set; } //介绍
        public string AurhorDescription { get; set; } //作者介绍
        public string EditorComment { get; set; } //
        public string TOC { get; set; } //
        public Category Category
        { get; set; }
        public Publisher Publisher
        { get; set; }
    }
}
