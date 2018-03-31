using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.Model;
using BooksManager.DAL;

namespace BooksManager.BLL
{
    public class CityManager
    {
        public static List<City> GetCitiesByProvinceId(int provinceId)
        {
            return CityService.GetCitiesByProvinceId(provinceId);
        }
    }
}
