using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{
    public static partial class SearchKeywordService
    {

        public static string[] GetHotSearchKeywords(string keyword)
        {
            IList<SearchKeyword> keywords = new List<SearchKeyword>();
            List<string> results = new List<string>();

            string sqlHot = "select top 10 * from SearchKeywords where keyword like '" + keyword + "%' order by SearchCount desc";
            keywords = GetSearchKeywordsBySql(sqlHot);
            foreach (SearchKeyword item in keywords)
            {
                results.Add(item.Keyword);
            }

            return results.ToArray();
        }
    }
}
