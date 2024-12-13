using System;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Models;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgiler
            string firstName = textBoxName.Text.Trim();
            string lastName = textBoxUsername.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxTelephoneNumber.Text.Trim();
            string address = textBoxAdress.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string role = "user"; // Varsayılan rol

            // Validasyon
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Geçersiz email formatı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Kullanıcı modeli oluştur
                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Phone = phone,
                    Address = address,
                    Password = password,
                    Role = role
                };

                // Kullanıcıyı kaydetmek için UserRepository kullan
                var userRepo = new UserRepository();

                // Kullanıcı zaten mevcut mu kontrol et
                var existingUser = userRepo.GetUserByEmail(email);
                if (existingUser != null)
                {
                    MessageBox.Show("Bu email adresiyle zaten bir kullanıcı kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni kullanıcıyı ekle
                userRepo.AddUser(newUser);

                MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kayıt başarılı, giriş ekranına dön
                Form1 loginForm = new Form1();
                loginForm.Show(); // Giriş formunu aç
                this.Hide();      // Kayıt formunu gizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Email doğrulama
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
    }
}
