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
	//[DBTable("Users")]
	[Serializable()]
	public class User
	{
		////////////////////////////////////////////
		//  Member Variables
		////////////////////////////////////////////
		private int id; 
		private UserState userState; 
		private UserRole userRole; 
		private string loginId = String.Empty;
		private string loginPwd = String.Empty;
		private string name = String.Empty;
		private string address = String.Empty;
		private string phone = String.Empty;
		private string mail = String.Empty;

		
		////////////////////////////////////////////
		//  Contructor
		////////////////////////////////////////////
		public User() { }
		
		
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
		//[DBField("UserStateId")]
		public UserState UserState
		{
			get { return this.userState; }
			set { this.userState = value; }
		}		
		
		//[DBField("UserRoleId")]
		public UserRole UserRole
		{
			get { return this.userRole; }
			set { this.userRole = value; }
		}		
		
		
		////////////////////////////////////////////
		//  Properties
		////////////////////////////////////////////
		//[DBField("LoginId")]
		public string LoginId
		{
			get { return this.loginId; }
			set { this.loginId = value; }
		}		
		
		//[DBField("LoginPwd")]
		public string LoginPwd
		{
			get { return this.loginPwd; }
			set { this.loginPwd = value; }
		}		
		
		//[DBField("Name")]
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}		
		
		//[DBField("Address")]
		public string Address
		{
			get { return this.address; }
			set { this.address = value; }
		}		
		
		//[DBField("Phone")]
		public string Phone
		{
			get { return this.phone; }
			set { this.phone = value; }
		}		
		
		//[DBField("Mail")]
		public string Mail
		{
			get { return this.mail; }
			set { this.mail = value; }
		}		
		
	}
}
