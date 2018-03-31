using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Model;
using MySchool.DAL;

namespace MySchool.BLL
{
    public class NewsTypeManager
    {
        public static NewsType GetAllTypeByTypeId(int typeid)
        {
            return NewsTypeService.GetAllTypeByTypeId(typeid);
        }
        public static List<NewsType> GetAllType()
        {
            return NewsTypeService.GetAllType();
        }
    }
}
