using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{
    public static partial class SearchKeywordManager
    {
        public static string[] GetHotSearchKeywords(string keyword)
        {
            return SearchKeywordService.GetHotSearchKeywords(keyword);
        }
    }
}
