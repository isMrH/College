using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooksManager.Model;
using BooksManager.DAL;


namespace BooksManager.BLL
{
    public class ProvinceManager
    {
        public static List<Province> GetAllProvinces()
        {
            return ProvinceService.GetAllProvinces();
        }

    }
}
