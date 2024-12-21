using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ProjeAdi.Repositories
{
    public static class DatabaseHelper
    {
        // Connection String
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(ConnectionString);

                // Bağlantının durumunu kontrol et
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    return connection; // Zaten açık bağlantıyı döndür
                }

                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanı bağlantısı başarısız oldu: " + ex.Message);
            }
        }
    }
}
