using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Models
{
    [Serializable()]
    public class NewsType
    {
        public NewsType() { }
        public int TypeId
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }      
        
        public string Remark
        {
            get;
            set;
        }

    }
}
