using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManager.Model
{
    public class City
    {
        int cityId;
        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        string cityName;
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        int provinceId;
        public int ProvinceId
        {
            get { return provinceId; }
            set { provinceId = value; }
        }
    }
}
