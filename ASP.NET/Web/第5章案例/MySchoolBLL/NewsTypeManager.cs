using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
    public static partial class NewsTypeManager
    {
        public static NewsType AddNewsType(NewsType newsType)
        {
            return NewsTypeService.AddNewsType(newsType);
        }

        public static void DeleteNewsType(NewsType newsType)
        {
            NewsTypeService.DeleteNewsType(newsType);
        }

        public static void DeleteNewsTypeById(int typeId)
        {
            NewsTypeService.DeleteNewsTypeByTypeId (typeId);
        }

        public static void ModifyNewsType(NewsType newsType)
        {
            NewsTypeService.ModifyNewsType(newsType);
        }

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
