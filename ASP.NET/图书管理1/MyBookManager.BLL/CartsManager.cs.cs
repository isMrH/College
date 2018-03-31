using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBook.Model;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class CartsManager
    {
        CartsService cs = new CartsService();
        public  List<Carts> GetAllInfo(string Loginid)
        {
            return cs.GetAllInfo(Loginid);
        }
        public int IsHasInfo(string bookName, string userid)
        {
            return cs.IsHasInfo(bookName, userid);
        }
        public int SelectCount(string bookName, string userid)
        {
            return cs.SelectCount(bookName, userid);
        }
        public int UpdateCount(int count, string id, string bookname) 
        {
            return cs.UpdateCount(count, id, bookname);
        }
        public int AddInfo(Carts cart)
        {
            return cs.AddInfo(cart);
        }
        public int DeleteById(string name, string id)
        {
            return cs.DeleteById(name, id);
        }
        public void DeleteInfo(string loginid)
        {
             cs.DeleteInfo(loginid);
        }
    }
}
