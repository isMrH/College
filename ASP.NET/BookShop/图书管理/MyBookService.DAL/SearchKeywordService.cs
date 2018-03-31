using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyBookService.DAL
{
    public class SearchKeywordService
    {
        public string[] GetHotSearchKeyWords(string prefixText, int count)
        {
            try
            {
                string strsql = "select top " + count + " * from SearchKeywords where  keyword like '" + prefixText + "%' order by searchcount desc";
                string[] dispalycount = new string[count];
                List<string> list = new List<string>();
                DataTable dr = DBHelper.GetTable(strsql);
                foreach (DataRow row in dr.Rows)
                {
                    list.Add(row["KeyWord"].ToString());
                }
                dispalycount = list.ToArray();
                return dispalycount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
