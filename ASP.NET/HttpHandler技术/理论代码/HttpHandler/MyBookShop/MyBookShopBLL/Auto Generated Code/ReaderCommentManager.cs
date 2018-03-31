//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:18
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using MyBookShop.DAL;
using MyBookShop.Models;

namespace MyBookShop.BLL
{

    public static partial class ReaderCommentManager
    {
        public static ReaderComment AddReaderComment(ReaderComment readerComment)
        {
            return ReaderCommentService.AddReaderComment(readerComment);
        }

        public static void DeleteReaderComment(ReaderComment readerComment)
        {
            ReaderCommentService.DeleteReaderComment(readerComment);
        }

        public static void DeleteReaderCommentById(string readerName)
        {
            ReaderCommentService.DeleteReaderCommentById(readerName);
        }

		public static void ModifyReaderComment(ReaderComment readerComment)
        {
            ReaderCommentService.ModifyReaderComment(readerComment);
        }
        
        public static IList<ReaderComment> GetAllReaderComments()
        {
            return ReaderCommentService.GetAllReaderComments();
        }

        public static ReaderComment GetReaderCommentByReaderName(string readerName)
        {
            return ReaderCommentService.GetReaderCommentByReaderName(readerName);
        }

    }
}
