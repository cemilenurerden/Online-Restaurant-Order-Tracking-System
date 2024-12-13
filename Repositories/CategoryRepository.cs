using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT category_id, category_name FROM categories";
                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            Id = reader.GetInt32("category_id"),
                            Name = reader.GetString("category_name"),
                            
                        });
                    }
                }
            }
            return categories;
        }
    }
}
