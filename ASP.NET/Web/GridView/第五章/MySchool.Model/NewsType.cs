using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Model
{
    public class NewsType
    {
        int typeId;
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string remark;
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
