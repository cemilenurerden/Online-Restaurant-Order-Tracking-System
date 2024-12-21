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
        public void AddProduct(Product product)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO products (name, description, image, price, category_id) " +
                               "VALUES (@Name, @Description, @Image, @Price, @CategoryId)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.description);
                command.Parameters.AddWithValue("@Image", product.ImagePath);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);

            
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
                            description = reader.GetString("description"),
                            ImagePath = reader.GetString("image"),
                            Price = reader.GetDecimal("price"),
                            CategoryId = reader.GetInt32("category_id")
                        });
                    }
                }
            }
            return products;
        }

        // 3. UPDATE (Ürün Güncelleme)
        public void UpdateProduct(Product product)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE products SET name = @Name, description = @Description, image = @Image, " +
                               "price = @Price, category_id = @CategoryId WHERE product_id = @Id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.description);
                command.Parameters.AddWithValue("@Image", product.ImagePath);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);

          
                command.ExecuteNonQuery();
            }
        }

        // 4. DELETE (Ürün Silme)
        public void DeleteProduct(int productId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM products WHERE product_id = @ProductId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);

           
                command.ExecuteNonQuery();
            }
        }

        // 5. Belirli bir ID ile Ürün Getirme
        public Product GetProductById(int productId)
        {
            Product product = null;

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM products WHERE product_id = @ProductId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);

             
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            Id = reader.GetInt32("product_id"),
                            Name = reader.GetString("name"),
                            description = reader.GetString("description"),
                            ImagePath = reader.GetString("image"),
                            Price = reader.GetDecimal("price"),
                            CategoryId = reader.GetInt32("category_id")
                        };
                    }
                }
            }

            return product;
        }

        // 6. Belirli Kategori ID'sine Göre Ürün Listeleme
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = new List<Product>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM products WHERE category_id = @CategoryId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryId", categoryId);

              
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("product_id"),
                            Name = reader.GetString("name"),
                            description = reader.GetString("description"),
                            ImagePath = reader.GetString("image"),
                            Price = reader.GetDecimal("price"),
                            CategoryId = reader.GetInt32("category_id")
                        });
                    }
                }
            }
            return products;
        }

        // 7. Arama (Ürün İsmi ile)
        public List<Product> SearchProducts(string keyword)
        {
            var products = new List<Product>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM products WHERE name LIKE @Keyword";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

             
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("product_id"),
                            Name = reader.GetString("name"),
                            description = reader.GetString("description"),
                            ImagePath = reader.GetString("image"),
                            Price = reader.GetDecimal("price"),
                            CategoryId = reader.GetInt32("category_id")
                        });
                    }
                }
            }

            return products;
        }
    }
}
