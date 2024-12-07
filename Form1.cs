using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// önce 
// git add . 
// git commit -m "yorum"
// git push
// sonra
// sync dan onayla


namespace Online_Restaurant_Order_Tracking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan giriş bilgileri
            string enteredUsername = textBoxUsername.Text; // Kullanıcı adı giriş textbox'ı
            string enteredPassword = textBoxPassword.Text; // Şifre giriş textbox'ı

            // Veritabanı bağlantı dizesi
            string connectionString = "Server=localhost;Database=restaurantsystem;User Id=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // Kullanıcı adı ve şifreyi kontrol eden SQL sorgusu
                    string query = "SELECT COUNT(*) FROM users WHERE email = @Username AND password = @Password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@Username", enteredUsername);
                        command.Parameters.AddWithValue("@Password", enteredPassword);

                        // Sonuç al
                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Başarılı giriş sonrası menüye geçiş
                            menu menum = new menu();
                            menum.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); // Kayıt Ol formunu aç
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelGirisEkrani_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
