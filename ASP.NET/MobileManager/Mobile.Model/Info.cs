using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobile.Model
{
    [Serializable]
    public class Info
    {
        public int Mid { get; set; }
        public int Bid { get; set; }
        public string MType { get; set; }
        public string OS { get; set; }
        public string ScreenSize { get; set; }
        public string Weights { get; set; }
        public DateTime DateOfListing { get; set; }
        public float Unitprice { get; set; }
        public int Remain { get; set; }
        public string IsIntelligent { get; set; }
    }
}
