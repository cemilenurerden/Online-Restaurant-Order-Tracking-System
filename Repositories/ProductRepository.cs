using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class ProductRepository
    {
        // 1. CREATE (Yeni Ürün Ekleme)
        public void AddProduct(string name, decimal price, string imagePath)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO products (name, price, image_path) VALUES (@Name, @Price, @ImagePath)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@ImagePath", imagePath);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 2. READ (Tüm Ürünleri Listele)
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM products";
                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("product_id"),
                            Name = reader.GetString("name"),
                            Price = (int)reader.GetDecimal("price"),
                            ImagePath = reader.GetString("image")
                        });
                    }
                }
            }
            return products;
        }

        // 3. UPDATE (Ürün Güncelleme)
        public void UpdateProduct(int id, string name, decimal price, string imagePath)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE products SET name = @Name, price = @Price, image_path = @ImagePath WHERE id = @Id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@ImagePath", imagePath);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 4. DELETE (Ürün Silme)
        public void DeleteProduct(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM products WHERE id = @Id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 5. Özel İşlem: Ürünleri Fiyat Aralığı ile Listeleme
        public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            var products = new List<Product>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM products WHERE price BETWEEN @MinPrice AND @MaxPrice";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MinPrice", minPrice);
                command.Parameters.AddWithValue("@MaxPrice", maxPrice);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Price = (int)reader.GetDecimal("price"),
                            ImagePath = reader.GetString("image_path")
                        });
                    }
                }
            }
            return products;
        }
        public List<Product> SearchProducts(string keyword)
        {
            var products = new List<Product>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM urunler WHERE urun_adi LIKE @Keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                           Id = reader.GetInt32("id"),
                           Name = reader.GetString("urun_adi"),
                            Price = reader.GetDecimal("fiyat")
                        });
                    }
                }
            }

            return products;
        }
    }
}
