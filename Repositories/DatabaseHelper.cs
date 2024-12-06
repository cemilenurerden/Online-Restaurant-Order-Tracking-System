using System;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ProjeAdi.Repositories
{
    public static class DatabaseHelper
    {
        // MySQL bağlantı dizesi
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        // Bağlantıyı açma ve döndürmexx
        public static MySqlConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(ConnectionString);
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
