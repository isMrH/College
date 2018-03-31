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
        public static List<NewsType> GetAllNewsTypes()
        {
            return NewsTypeService.GetAllNewsTypes();
        }
        public static NewsType GetNewsTypeByTypeId(int typeId)
        {
            return NewsTypeService.GetNewsTypeByTypeId(typeId);
        }
    }
}
