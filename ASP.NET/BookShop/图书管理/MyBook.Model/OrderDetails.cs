using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBook.Model
{
    public class OrderDetails
    {
        //订单表编号
        public int Id { get; set; }
        //书名
        public string BookName { get; set; }
        //书的图片
        public string BookImage { get; set; }
        //书的数量
        public int BookCount { get; set; }
        //书的单价
        public double BookPrice { get; set; }
        //用户id
        public string UserId { get; set; }
        //总价
        public double Total { get; set; }
        //购买日期
        public DateTime BuyDate { get; set; }
    }
}
