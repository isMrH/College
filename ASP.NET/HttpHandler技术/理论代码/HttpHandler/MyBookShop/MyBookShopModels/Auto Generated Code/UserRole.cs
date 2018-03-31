//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookShop.Models
{
	//[DBTable("UserRoles")]
	[Serializable()]
	public class UserRole
	{
		////////////////////////////////////////////
		//  Member Variables
		////////////////////////////////////////////
		private int id; 
		private string name = String.Empty;

		
		////////////////////////////////////////////
		//  Contructor
		////////////////////////////////////////////
		public UserRole() { }
		
		
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
		//[DBField("Name")]
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}		
		
	}
}
