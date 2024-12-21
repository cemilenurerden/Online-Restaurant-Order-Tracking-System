using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using ProjeAdi.Repositories;
using System;
using System.Collections.Generic;

namespace Online_Restaurant_Order_Tracking_System.Repositories
{
    public class UserRepository
    {
        // Kullanıcı ekleme
        public void AddUser(User user)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = @"
                INSERT INTO users (first_name, last_name, email, phone,  password, role)
                VALUES (@FirstName, @LastName, @Email, @Phone,  @Password, @Role)";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);

               
                command.ExecuteNonQuery();
            }
        }

        // Tüm kullanıcıları getir
        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM users";
                var command = new MySqlCommand(query, connection);

               
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserId = reader.GetInt32("id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            Email = reader.GetString("email"),
                            Phone = reader.GetString("phone"),
                            Password = reader.GetString("password"),
                            Role = reader.GetString("role")
                        });
                    }
                }
            }
            return users;
        }

        // Kullanıcıyı ID'ye göre getir
        public User GetUserById(int userId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM users WHERE id = @UserId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

              
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = reader.GetInt32("id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            Email = reader.GetString("email"),
                            Phone = reader.GetString("phone"),
                            Password = reader.GetString("password"),
                            Role = reader.GetString("role")
                        };
                    }
                }
            }
            return null;
        }

        // Email ile kullanıcıyı getir
        public User GetUserByEmail(string email)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM users WHERE email = @Email";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

     
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = reader.GetInt32("id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            Email = reader.GetString("email"),
                            Phone = reader.GetString("phone"),
                            Password = reader.GetString("password"),
                            Role = reader.GetString("role")
                        };
                    }
                }
            }
            return null;
        }

        // Kullanıcı güncelleme
        public void UpdateUser(User user)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = @"
                UPDATE users
                SET first_name = @FirstName, last_name = @LastName, email = @Email, 
                    phone = @Phone,  password = @Password, role = @Role
                WHERE id = @UserId";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@UserId", user.UserId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Kullanıcı silme
        public void DeleteUser(int userId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM users WHERE id = @UserId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
    }
}
