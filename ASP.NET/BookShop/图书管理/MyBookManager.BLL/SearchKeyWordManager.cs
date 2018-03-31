using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBookService.DAL;

namespace MyBookManager.BLL
{
    public class SearchKeyWordManager
    {
        SearchKeywordService sks = new SearchKeywordService();
        public string[] GetHotSearchKeyWords(string prefixText, int count)
        {
            return sks.GetHotSearchKeyWords(prefixText, count);
        }

    }
}
