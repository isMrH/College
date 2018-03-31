using System;
using System.Collections.Generic;
using System.Text;

namespace Myblog.Model
{
     public class Article
    {

         public int Id
         {
             get;
             set;
         }

         public int AuthorId
         {
             get;
             set;
         }

         public string Title
         {
             get;
             set;
         }

         public string Contents
         {
             get;
             set;
         }

         public DateTime PubDate
         {
             get;
             set;
         }

         public int Clicks
         {
             get;
             set;
         }

    }
}
