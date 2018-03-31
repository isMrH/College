using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class OrderDetailsManager
    {
        OrderDetailsSerivce od = new OrderDetailsSerivce();
        //根据id查询图书类型
        public List<OrderDetails> GetInfoByid(string id)
        {
            return od.GetInfoByid(id);
        }
         //往订单表中添加信息
        public int AddInfoByid(OrderDetails ods)
        {
            return od.AddInfoByid(ods);
        }
        //删除信息
        public int DeleteInfo(string name, string id)
        {
            return od.DeleteInfo(name, id);
        }
    }
}
