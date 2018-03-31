using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class CartManager
    {
       CartService cs = new CartService();
         //得到所有信息
       public List<Carts> GetAllInfo(string id)
       {
           return cs.GetAllInfo(id);
       }
        //修改数量
       public int UpdateCount(int count, string  id,string bookname)
       {
           return cs.UpdateCount(count, id, bookname);
       }
         //根据id删除信息
       public int DeleteById(string name,string  id)
       {
           return cs.DeleteById(name, id);
       }
         //查看该账户中是否有这本书的信息
       public int IsHasInfo(string bookName, string userid)
       {
           return cs.IsHasInfo(bookName, userid);
       }
         //查看数量
        public int SelectCount(string bookName, string userid)
        {
            return cs.SelectCount(bookName, userid);
        }
         //添加信息
        public int AddInfo(Carts cart)
        {
            return cs.AddInfo(cart);
        }
        //删除某客户的已支付图书信息
        public void DeleteInfo(string loginid)
        {
            cs.DeleteInfo(loginid);
        }
        //查找该本书
        public Carts GetByName(string name, string userid)
        {
            return cs.GetByName(name, userid);
        }
    }
}
