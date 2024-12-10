using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; 

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_kayit_ekrani_Click(object sender, EventArgs e)
        {

        }

       

private void buttonKayitOl_Click(object sender, EventArgs e)
    {
        // Kullanıcıdan alınan bilgiler
        string firstName = textBoxName.Text;
        string lastName = textBoxUsername.Text;
        string email = textBoxEmail.Text;
        string phone = textBoxTelephoneNumber.Text;
        string address = textBoxAdress.Text;
        string password = textBoxPassword.Text;
        string role = "user"; // Varsayılan rol

        // Alanların boş olup olmadığını kontrol et
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
            string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
            string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Veritabanına ekleme
        try
        {
                // MySQL bağlantı dizesi
                string connectionString = "Server=localhost;Database=restaurantsystem;User Id=root;Password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusu
                string query = "INSERT INTO users (first_name, last_name, email, phone, address, password, role) " +
                               "VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @Password, @Role)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parametreler
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kayıt başarılı, giriş ekranına dön
            Form1 loginForm = new Form1();
            loginForm.Show(); // Giriş formunu aç
            this.Hide();      // Kayıt formunu gizle
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Kayıt başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAdress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
