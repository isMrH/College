using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7作业2
{
    class GoldPlateIComparer:IComparer<Country>
    {
        public int Compare(Country x, Country y)
        {
            return y.GoldPlate.CompareTo(x.GoldPlate);
        }
    }
}
