using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Model
{
    public class News
    {
        int newsId;

        public int NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }
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
        string pictureUrl;

        public string PictureUrl
        {
            get { return pictureUrl; }
            set { pictureUrl = value; }
        }
        DateTime publishDate;

        public DateTime PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        string publisherName;

        public string PublisherName
        {
            get { return publisherName; }
            set { publisherName = value; }
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
        int isTop;

        public int IsTop
        {
            get { return isTop; }
            set { isTop = value; }
        }
    }
}
