using System;
using System.Collections.Generic;
using System.Text;

namespace Myblog.Model
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
