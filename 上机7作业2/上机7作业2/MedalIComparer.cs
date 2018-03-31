using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机7作业2
{
    class MedalIComparer : IComparer<Country>
    {
        public int Compare(Country x,Country y)
        {
            return y.Medal.CompareTo(x.Medal);
        }
    }
}
