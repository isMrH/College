//======================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (shenbo@boboarts.com)
// Auto generated at: 	2007-9-5 10:23:08
//======================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{
	public static partial class SearchKeywordService
	{      	
        private static IList<SearchKeyword> GetSearchKeywordsBySql( string safeSql )
        {
            List<SearchKeyword> list = new List<SearchKeyword>();

            DataTable table = DBHelper.GetDataSet( safeSql );
			
            foreach (DataRow row in table.Rows)
            {
                SearchKeyword searchKeyword = new SearchKeyword();
				
                searchKeyword.Id = (int)row["Id"];
                searchKeyword.Keyword = (string)row["Keyword"];
                searchKeyword.SearchCount = (int)row["SearchCount"];

                list.Add(searchKeyword);
            }

            return list;
        }
		
        private static IList<SearchKeyword> GetSearchKeywordsBySql( string sql, params SqlParameter[] values )
        {
            List<SearchKeyword> list = new List<SearchKeyword>();

            DataTable table = DBHelper.GetDataSet( sql, values );
			
            foreach (DataRow row in table.Rows)
            {
                SearchKeyword searchKeyword = new SearchKeyword();
				
                searchKeyword.Id = (int)row["Id"];
                searchKeyword.Keyword = (string)row["Keyword"];
                searchKeyword.SearchCount = (int)row["SearchCount"];

                list.Add(searchKeyword);
            }

            return list;
        }
		
	}
}
