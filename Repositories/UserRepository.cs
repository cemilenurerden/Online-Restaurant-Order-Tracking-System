using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Online_Restaurant_Order_Tracking_System.Models;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM kullanicilar";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User
                    {
                        userId = reader.GetInt32("id"),
                        firstName = reader.GetString("ad"),
                        lastName = reader.GetString("soyad"),
                        email = reader.GetString("email"),
                        password = reader.GetString("sifre")
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        // Yeni kullanıcı eklemekskkk
        public bool AddUser(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO kullanicilar (ad, soyad, email, sifre) VALUES (@ad, @soyad, @email, @sifre)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ad", user.firstName);
                cmd.Parameters.AddWithValue("@soyad", user.lastName);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@sifre", user.password);

                int result = cmd.ExecuteNonQuery();
                return result > 0; // 1 veya daha fazla satır etkilenmişse true döner
            }
        }
    }
}
