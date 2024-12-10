using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; // MySQL için gerekli paket
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class OrderRepository
    {

        // CRUD İşlemleri

        // 1. CREATE (Yeni Sipariş Ekleme)
        public void AddOrder(int userId, int productId, int quantity, int orderDate)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                
                string query = "INSERT INTO order_details (_id, product_id, quantity, unit_price,total_price) VALUES (@UserId, @ProductId, @Quantity, @Quantity, @OrderDate)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@OrderDate", orderDate);

                command.ExecuteNonQuery();
            }
        }

        // 2. READ (Tüm Siparişleri Listele)
        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM orders";
                var command = new MySqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32("order_id"),
                            userId = reader.GetInt32("user_id"),
                            ProductId = reader.GetInt32("product_id"),
                            quantity = reader.GetInt32("quantity"),
                            OrderDate = reader.GetDateTime("order_date")
                        });
                    }
                }
            }
            return orders;
        }

        // 3. UPDATE (Sipariş Güncelleme)
        public void UpdateOrder(int orderId, int quantity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE orders SET quantity = @Quantity WHERE order_id = @OrderId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@OrderId", orderId);

                command.ExecuteNonQuery();
            }
        }

        // 4. DELETE (Sipariş Silme)
        public void DeleteOrder(int orderId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM orders WHERE order_id = @OrderId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderId", orderId);

                command.ExecuteNonQuery();
            }
        }

        // 5. Özel İşlem: Siparişleri Kullanıcı ID ile Listeleme
        public List<Order> GetOrdersByUserId(int userId)
        {
            var orders = new List<Order>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM orders WHERE user_id = @UserId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32("order_id"),
                            userId = reader.GetInt32("user_id"),
                            ProductId = reader.GetInt32("product_id"),
                            quantity = reader.GetInt32("quantity"),
                            OrderDate = reader.GetDateTime("order_date")
                        });
                    }
                }
            }
            return orders;
        }
    }
}