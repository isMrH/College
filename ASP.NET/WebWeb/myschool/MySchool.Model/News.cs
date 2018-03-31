using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Model
{
    [ Serializable]
    public class News
    {
        public int NewsId { get; set; }
        //public int TypeId { get; set; }
        public NewsType Type { get; set; }
        public string Title { get; set; }
        public string PictureUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublisherName { get; set; }
        public int Clicks { get; set; }
        public int State { get; set; }
        public string Contents { get; set; }
        public int IsTop { get; set; }
    }
}
