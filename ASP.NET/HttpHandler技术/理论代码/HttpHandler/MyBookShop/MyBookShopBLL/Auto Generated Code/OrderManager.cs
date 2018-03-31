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

    public static partial class OrderManager
    {
        public static Order AddOrder(Order order)
        {
            return OrderService.AddOrder(order);
        }

        public static void DeleteOrder(Order order)
        {
            OrderService.DeleteOrder(order);
        }

        public static void DeleteOrderById(int id)
        {
            OrderService.DeleteOrderById(id);
        }

		public static void ModifyOrder(Order order)
        {
            OrderService.ModifyOrder(order);
        }
        
        public static IList<Order> GetAllOrders()
        {
            return OrderService.GetAllOrders();
        }

        public static Order GetOrderById(int id)
        {
            return OrderService.GetOrderById(id);
        }

    }
}
