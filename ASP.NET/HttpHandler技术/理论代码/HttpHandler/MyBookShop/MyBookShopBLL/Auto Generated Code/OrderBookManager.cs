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

    public static partial class OrderBookManager
    {
        public static OrderBook AddOrderBook(OrderBook orderBook)
        {
            return OrderBookService.AddOrderBook(orderBook);
        }

        public static void DeleteOrderBook(OrderBook orderBook)
        {
            OrderBookService.DeleteOrderBook(orderBook);
        }

        public static void DeleteOrderBookById(int id)
        {
            OrderBookService.DeleteOrderBookById(id);
        }

		public static void ModifyOrderBook(OrderBook orderBook)
        {
            OrderBookService.ModifyOrderBook(orderBook);
        }
        
        public static IList<OrderBook> GetAllOrderBooks()
        {
            return OrderBookService.GetAllOrderBooks();
        }

        public static OrderBook GetOrderBookById(int id)
        {
            return OrderBookService.GetOrderBookById(id);
        }

    }
}
