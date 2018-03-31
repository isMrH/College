//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:18
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookShop.Models
{
	//[DBTable("SearchKeywords")]
	[Serializable()]
	public class SearchKeyword
	{
		////////////////////////////////////////////
		//  Member Variables
		////////////////////////////////////////////
		private int id; 
		private string keyword = String.Empty;
		private int searchCount;

		
		////////////////////////////////////////////
		//  Contructor
		////////////////////////////////////////////
		public SearchKeyword() { }
		
		
		////////////////////////////////////////////
		//  Primary Key
		////////////////////////////////////////////
		//[DBField("Id")]
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		
		
		
		////////////////////////////////////////////
		//  Properties
		////////////////////////////////////////////
		//[DBField("Keyword")]
		public string Keyword
		{
			get { return this.keyword; }
			set { this.keyword = value; }
		}		
		
		//[DBField("SearchCount")]
		public int SearchCount
		{
			get { return this.searchCount; }
			set { this.searchCount = value; }
		}		
		
	}
}
