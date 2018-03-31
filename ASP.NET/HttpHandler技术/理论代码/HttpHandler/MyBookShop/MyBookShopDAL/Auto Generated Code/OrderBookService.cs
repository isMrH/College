//============================================================
// Producnt name:		BoBoARTS.DBMad
// Version: 			1.0
// Coded by:			Shen Bo (bo.shen@jb-aptech.com.cn)
// Auto generated at: 	2007-9-6 17:40:18
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBookShop.Models;

namespace MyBookShop.DAL
{
	public static partial class OrderBookService
	{
        public static OrderBook AddOrderBook(OrderBook orderBook)
		{
            string sql =
				"INSERT OrderBook (OrderID, BookID, Quantity, UnitPrice)" +
				"VALUES (@OrderID, @BookID, @Quantity, @UnitPrice)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@BookID", orderBook.Book.Id), //FK
					new SqlParameter("@OrderID", orderBook.Order.Id), //FK
					new SqlParameter("@Quantity", orderBook.Quantity),
					new SqlParameter("@UnitPrice", orderBook.UnitPrice)
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetOrderBookById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                return null;
            }
		}
		
        public static void DeleteOrderBook(OrderBook orderBook)
		{
			DeleteOrderBookById( orderBook.Id );
		}

        public static void DeleteOrderBookById(int id)
		{
            string sql = "DELETE OrderBook WHERE Id = @Id";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyOrderBook(OrderBook orderBook)
        {
            string sql =
                "UPDATE OrderBook " +
                "SET " +
	                "BookID = @BookID, " + //FK
	                "OrderID = @OrderID, " + //FK
	                "Quantity = @Quantity, " +
	                "UnitPrice = @UnitPrice " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", orderBook.Id),
					new SqlParameter("@BookID", orderBook.Book.Id), //FK
					new SqlParameter("@OrderID", orderBook.Order.Id), //FK
					new SqlParameter("@Quantity", orderBook.Quantity),
					new SqlParameter("@UnitPrice", orderBook.UnitPrice)
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<OrderBook> GetAllOrderBooks()
        {
            string sqlAll = "SELECT * FROM OrderBook";
			return GetOrderBooksBySql( sqlAll );
        }
		
        public static OrderBook GetOrderBookById(int id)
        {
            string sql = "SELECT * FROM OrderBook WHERE Id = @Id";

			int bookID;
			int orderID;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
                    OrderBook orderBook = new OrderBook();

					orderBook.Id = (int)reader["Id"];
					orderBook.Quantity = (int)reader["Quantity"];
					orderBook.UnitPrice = (decimal)reader["UnitPrice"];
					bookID = (int)reader["BookID"]; //FK
					orderID = (int)reader["OrderID"]; //FK

                    reader.Close();

					orderBook.Book = BookService.GetBookById(bookID);
					orderBook.Order = OrderService.GetOrderById(orderID);
					
                    return orderBook;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
		
		
		
		
        private static IList<OrderBook> GetOrderBooksBySql( string safeSql )
        {
            List<OrderBook> list = new List<OrderBook>();

			try
			{
				DataTable table = DBHelper.GetDataSet( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					OrderBook orderBook = new OrderBook();
					
					orderBook.Id = (int)row["Id"];
					orderBook.Quantity = (int)row["Quantity"];
					orderBook.UnitPrice = (decimal)row["UnitPrice"];
					orderBook.Book = BookService.GetBookById((int)row["BookID"]); //FK
					orderBook.Order = OrderService.GetOrderById((int)row["OrderID"]); //FK
	
					list.Add(orderBook);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
		
        private static IList<OrderBook> GetOrderBooksBySql( string sql, params SqlParameter[] values )
        {
            List<OrderBook> list = new List<OrderBook>();

			try
			{
				DataTable table = DBHelper.GetDataSet( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					OrderBook orderBook = new OrderBook();
					
					orderBook.Id = (int)row["Id"];
					orderBook.Quantity = (int)row["Quantity"];
					orderBook.UnitPrice = (decimal)row["UnitPrice"];
					orderBook.Book = BookService.GetBookById((int)row["BookID"]); //FK
					orderBook.Order = OrderService.GetOrderById((int)row["OrderID"]); //FK
	
					list.Add(orderBook);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
			
        }
		
	}
}
