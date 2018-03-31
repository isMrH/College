using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.DAL;
using Mobile.Model;

namespace Mobile.BLL
{
    public class BrandManager
    {
        public static int InsertBrand(User u)
        {
            return BrandService.InsertBrand(u);
        }
        public static bool IsExists(string name)
        {
            return BrandService.IsExists(name);
        }
        public static List<User> GetALLBrand()
        {
            return BrandService.GetALLBrand();
        }
        public static int UpdateBrand(User u)
        {
            return BrandService.UpdateBrand(u);
        }
        public static int DeleteBrand(string bid)
        {
            return BrandService.DeleteBrand(bid);
        }
    }
}
