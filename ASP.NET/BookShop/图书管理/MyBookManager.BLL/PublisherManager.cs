using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBookService.DAL;
using MyBook.Model;

namespace MyBookManager.BLL
{
    public class PublisherManager
    {
        PublisherService ps = new PublisherService();
        //根据id查询图书类型
        public Publisher GetPublishersByID(int id)
        {
            return ps.GetPublishersByID(id);
        }
    }
}
