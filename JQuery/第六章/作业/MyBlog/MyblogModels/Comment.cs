using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogModels
{  
    public class Comment
    {

        public int Id
        {
            get;
            set;
        }

        public int ArticleId
        {
            get;
            set;
        }

        public string AuthorName
        {
            get;
            set;
        }
       
        public string Contents
        {
            get;
            set ;
        }

        public DateTime PubDate
        {
            get;
            set;
        }

    }
}
