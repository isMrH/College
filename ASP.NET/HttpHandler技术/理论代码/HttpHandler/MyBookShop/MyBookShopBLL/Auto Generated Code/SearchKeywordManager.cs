//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class SearchKeywordManager
    {
        public static SearchKeyword AddSearchKeyword(SearchKeyword searchKeyword)
        {
            return SearchKeywordService.AddSearchKeyword(searchKeyword);
        }

        public static void DeleteSearchKeyword(SearchKeyword searchKeyword)
        {
            SearchKeywordService.DeleteSearchKeyword(searchKeyword);
        }

        public static void DeleteSearchKeywordById(int id)
        {
            SearchKeywordService.DeleteSearchKeywordById(id);
        }

		public static void ModifySearchKeyword(SearchKeyword searchKeyword)
        {
            SearchKeywordService.ModifySearchKeyword(searchKeyword);
        }
        
        public static IList<SearchKeyword> GetAllSearchKeywords()
        {
            return SearchKeywordService.GetAllSearchKeywords();
        }

        public static SearchKeyword GetSearchKeywordById(int id)
        {
            return SearchKeywordService.GetSearchKeywordById(id);
        }

    }
}
