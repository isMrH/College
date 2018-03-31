using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop.Model
{
    public class GoodsInfo
    {
        public int Id { get; set; }//商品id
        public string  GoodsName { get; set; }//商品名称
        public double  GoodsPrice { get; set; }//商品价格
        public int GoodsCount { get; set; }//商品数量
        public string  Company { get; set; }//厂家
    }
}
