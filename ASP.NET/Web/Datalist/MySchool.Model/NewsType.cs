using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Model
{
    public class NewsType
    {
        int typeid;

        public int Typeid
        {
            get { return typeid; }
            set { typeid = value; }
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
