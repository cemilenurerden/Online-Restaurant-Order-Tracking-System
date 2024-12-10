using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;
using System;
using System.Collections.Generic;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class UserRepository
    {
        // Tüm kullanıcıları listele
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
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
                        phone = reader.IsDBNull(reader.GetOrdinal("telefon")) ? null : reader.GetString("telefon"),
                        adress = reader.IsDBNull(reader.GetOrdinal("adres")) ? null : reader.GetString("adres"),
                        password = reader.GetString("sifre"),
                        role = (User.UserRole)Enum.Parse(typeof(User.UserRole), reader.GetString("rol"))
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        // Yeni kullanıcı ekle
        public bool AddUser(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO kullanicilar (ad, soyad, email, telefon, adres, sifre, rol) " +
                               "VALUES (@ad, @soyad, @email, @telefon, @adres, @sifre, @rol)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ad", user.firstName);
                cmd.Parameters.AddWithValue("@soyad", user.lastName);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@telefon", user.phone);
                cmd.Parameters.AddWithValue("@adres", user.adress);
                cmd.Parameters.AddWithValue("@sifre", user.password);
                cmd.Parameters.AddWithValue("@rol", user.role.ToString());

                int result = cmd.ExecuteNonQuery();
                return result > 0; // 1 veya daha fazla satır etkilenmişse true döner
            }
        }

        // Kullanıcıyı ID ile getir
        public User GetUserById(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM kullanicilar WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        userId = reader.GetInt32("id"),
                        firstName = reader.GetString("ad"),
                        lastName = reader.GetString("soyad"),
                        email = reader.GetString("email"),
                        phone = reader.IsDBNull(reader.GetOrdinal("telefon")) ? null : reader.GetString("telefon"),
                        adress = reader.IsDBNull(reader.GetOrdinal("adres")) ? null : reader.GetString("adres"),
                        password = reader.GetString("sifre"),
                        role = (User.UserRole)Enum.Parse(typeof(User.UserRole), reader.GetString("rol"))
                    };
                }
            }
            return null;
        }

        // Kullanıcı güncelle
        public bool UpdateUser(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE kullanicilar SET ad = @ad, soyad = @soyad, email = @email, telefon = @telefon, " +
                               "adres = @adres, sifre = @sifre, rol = @rol WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", user.userId);
                cmd.Parameters.AddWithValue("@ad", user.firstName);
                cmd.Parameters.AddWithValue("@soyad", user.lastName);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@telefon", user.phone);
                cmd.Parameters.AddWithValue("@adres", user.adress);
                cmd.Parameters.AddWithValue("@sifre", user.password);
                cmd.Parameters.AddWithValue("@rol", user.role.ToString());

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Kullanıcı sil
        public bool DeleteUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM kullanicilar WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Email ile kullanıcıyı getir
        public User GetUserByEmail(string email)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM kullanicilar WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        userId = reader.GetInt32("id"),
                        firstName = reader.GetString("ad"),
                        lastName = reader.GetString("soyad"),
                        email = reader.GetString("email"),
                        phone = reader.IsDBNull(reader.GetOrdinal("telefon")) ? null : reader.GetString("telefon"),
                        adress = reader.IsDBNull(reader.GetOrdinal("adres")) ? null : reader.GetString("adres"),
                        password = reader.GetString("sifre"),
                        role = (User.UserRole)Enum.Parse(typeof(User.UserRole), reader.GetString("rol"))
                    };
                }
            }
            return null;
        }
    }
}
