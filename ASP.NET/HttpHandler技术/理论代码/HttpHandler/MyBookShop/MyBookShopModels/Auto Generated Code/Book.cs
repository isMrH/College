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
	//[DBTable("Books")]
	[Serializable()]
	public class Book
	{
		////////////////////////////////////////////
		//  Member Variables
		////////////////////////////////////////////
		private int id; 
		private Publisher publisher; 
		private Category category; 
		private string title = String.Empty;
		private string author = String.Empty;
		private DateTime publishDate;
		private string iSBN = String.Empty;
		private int wordsCount;
		private decimal unitPrice;
		private string contentDescription = String.Empty;
		private string aurhorDescription = String.Empty;
		private string editorComment = String.Empty;
		private string tOC = String.Empty;
		private int clicks;

		
		////////////////////////////////////////////
		//  Contructor
		////////////////////////////////////////////
		public Book() { }
		
		
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
		//  Foreign Keys
		////////////////////////////////////////////
		//[DBField("PublisherId")]
		public Publisher Publisher
		{
			get { return this.publisher; }
			set { this.publisher = value; }
		}		
		
		//[DBField("CategoryId")]
		public Category Category
		{
			get { return this.category; }
			set { this.category = value; }
		}		
		
		
		////////////////////////////////////////////
		//  Properties
		////////////////////////////////////////////
		//[DBField("Title")]
		public string Title
		{
			get { return this.title; }
			set { this.title = value; }
		}		
		
		//[DBField("Author")]
		public string Author
		{
			get { return this.author; }
			set { this.author = value; }
		}		
		
		//[DBField("PublishDate")]
		public DateTime PublishDate
		{
			get { return this.publishDate; }
			set { this.publishDate = value; }
		}		
		
		//[DBField("ISBN")]
		public string ISBN
		{
			get { return this.iSBN; }
			set { this.iSBN = value; }
		}		
		
		//[DBField("WordsCount")]
		public int WordsCount
		{
			get { return this.wordsCount; }
			set { this.wordsCount = value; }
		}		
		
		//[DBField("UnitPrice")]
		public decimal UnitPrice
		{
			get { return this.unitPrice; }
			set { this.unitPrice = value; }
		}		
		
		//[DBField("ContentDescription")]
		public string ContentDescription
		{
			get { return this.contentDescription; }
			set { this.contentDescription = value; }
		}		
		
		//[DBField("AurhorDescription")]
		public string AurhorDescription
		{
			get { return this.aurhorDescription; }
			set { this.aurhorDescription = value; }
		}		
		
		//[DBField("EditorComment")]
		public string EditorComment
		{
			get { return this.editorComment; }
			set { this.editorComment = value; }
		}		
		
		//[DBField("TOC")]
		public string TOC
		{
			get { return this.tOC; }
			set { this.tOC = value; }
		}		
		
		//[DBField("Clicks")]
		public int Clicks
		{
			get { return this.clicks; }
			set { this.clicks = value; }
		}		
		
	}
}
