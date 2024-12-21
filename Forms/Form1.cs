using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Helpers;
using Online_Restaurant_Order_Tracking_System.Repositories;

// önce 
// git add . 
// git commit -m "yorum"
// git push
// sonra
// sync dan onayla


namespace Online_Restaurant_Order_Tracking_System.Forms
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
            string enteredEmail = textBoxUsername.Text; // Kullanıcı adı giriş textbox'ı
            string enteredPassword = textBoxPassword.Text; // Şifre giriş textbox'ı

            // Validasyon
            if (string.IsNullOrEmpty(enteredEmail) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Email ve şifre alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(enteredEmail))
            {
                MessageBox.Show("Geçersiz email formatı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kullanıcıyı email ile getir
                var userRepo = new UserRepository();
                var user = userRepo.GetUserByEmail(enteredEmail);

                if (user == null)
                {
                    MessageBox.Show("Bu email ile kayıtlı bir kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Şifre doğrulama
                if (user.Password != enteredPassword)
                {
                    MessageBox.Show("Yanlış şifre girdiniz. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Giriş başarılı: Session bilgilerini ayarla
                SessionManager.IsLoggedIn = true;
                SessionManager.UserId = user.UserId;
                SessionManager.UserRole = user.Role; // Rol bilgisini Session'da tut

                // Role göre yönlendirme
                if (user.Role == "admin")
                {
                    AdminHomePage adminForm = new AdminHomePage(); // Admin sayfası
                    adminForm.Show();
                    MessageBox.Show("Admin sayfasına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (user.Role == "worker")
                {
                    EmployeeHomePage employeeForm = new EmployeeHomePage(); // Çalışan sayfası
                    employeeForm.Show();
                    MessageBox.Show("Çalışan sayfasına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    menu mainForm = new menu(); // Kullanıcı ana sayfası
                    mainForm.Show();
                    MessageBox.Show("Kullanıcı sayfasına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide(); // Giriş formunu gizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriş sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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
