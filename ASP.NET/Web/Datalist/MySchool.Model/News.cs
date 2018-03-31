using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Model
{
    public class News
    {
        int newsid;

        public int Newsid
        {
            get { return newsid; }
            set { newsid = value; }
        }
        //int typeid;

        //public int Typeid
        //{
        //    get { return typeid; }
        //    set { typeid = value; }
        //}
        NewsType type;

        public NewsType Type
        {
            get { return type; }
            set { type = value; }
        }

        string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        string pictureurl;

        public string Pictureurl
        {
            get { return pictureurl; }
            set { pictureurl = value; }
        }
        DateTime publishdate;

        public DateTime Publishdate
        {
            get { return publishdate; }
            set { publishdate = value; }
        }
        string publishername;

        public string Publishername
        {
            get { return publishername; }
            set { publishername = value; }
        }
        int clicks;

        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }
        int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }
        string contents;

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }
        int istop;

        public int Istop
        {
            get { return istop; }
            set { istop = value; }
        }
    }
}
