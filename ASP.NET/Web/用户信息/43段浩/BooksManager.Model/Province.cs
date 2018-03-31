using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManager.Model
{
    public class Province
    {
        int provinceId;

        public int ProvinceId
        {
            get { return provinceId; }
            set { provinceId = value; }
        }
        string provinceName;

        public string ProvinceName
        {
            get { return provinceName; }
            set { provinceName = value; }
        }
    }
}
