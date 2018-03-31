using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Model;

namespace MySchool.BLL
{
    public class NewsTypeManager
    {
        public static NewsType GetNewsTypeByTypeId(int typeId)
        {
            return NewsTypeService.GetNewsTypeByTypeId(typeId);
        }
    }
}
