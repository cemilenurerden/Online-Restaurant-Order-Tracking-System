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
        public void AddOrder(int userId, string address, string paymentMethod, List<CartItem> cartItems)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                using (var transaction = connection.BeginTransaction()) // Transaction başlat
                {
                    try
                    {
                        // 1. orders tablosuna ekleme
                        string insertOrderQuery = @"INSERT INTO orders (user_id, total_price, status, address, payment_method) 
                                            VALUES (@UserId, @TotalPrice, @Status, @Address, @PaymentMethod);
                                            SELECT LAST_INSERT_ID();";

                        decimal totalOrderPrice = CalculateTotalPrice(cartItems);

                        int orderId; // Eklenen siparişin ID'si
                        using (var orderCommand = new MySqlCommand(insertOrderQuery, connection, transaction))
                        {
                            orderCommand.Parameters.AddWithValue("@UserId", userId);
                            orderCommand.Parameters.AddWithValue("@TotalPrice", totalOrderPrice);
                            orderCommand.Parameters.AddWithValue("@Status", "preparing");
                            orderCommand.Parameters.AddWithValue("@Address", address);
                            orderCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                            orderId = Convert.ToInt32(orderCommand.ExecuteScalar()); // Eklenen sipariş ID'sini al
                        }

                        // 2. order_details tablosuna her bir ürün detayını ekleme
                        string insertOrderDetailsQuery = @"INSERT INTO order_details (order_id, product_id, quantity, unit_price) 
                                                   VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)";

                        foreach (var item in cartItems)
                        {
                            using (var detailsCommand = new MySqlCommand(insertOrderDetailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@OrderId", orderId);
                                detailsCommand.Parameters.AddWithValue("@ProductId", item.ProductId);
                                detailsCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                                detailsCommand.Parameters.AddWithValue("@UnitPrice", item.Price);

                                detailsCommand.ExecuteNonQuery();
                            }
                        }

                        // Transaction'ı onayla
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Sipariş eklenirken hata oluştu: {ex.Message}");
                    }
                }
            }
        }
        private decimal CalculateTotalPrice(List<CartItem> cartItems)
        {
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }


        // 2. READ (Tüm Siparişleri Listele)
        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = @"
            SELECT 
                order_id,
                user_id,
                order_date,
                status,
                total_price,
                payment_method,
                address
            FROM orders";

                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32("order_id"),
                            userId = reader.GetInt32("user_id"),
                            OrderDate = reader.GetDateTime("order_date"),
                            status = reader.GetString("status"),
                            totalPrice = reader.GetDecimal("total_price"),
                            paymentMethod = reader.GetString("payment_method"),
                            address = reader.GetString("address"),
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