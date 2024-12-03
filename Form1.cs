using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Kullanıcı adı ve şifre kontrolü için örnek değerler
            string correctUsername = "admin";
            string correctPassword = "1234";

            // Kullanıcıdan alınan giriş bilgileri (textbox kontrol adlarınızı uygun şekilde değiştirin)
            string enteredUsername = textBoxUsername.Text; // Kullanıcı adı giriş textbox'ı
            string enteredPassword = textBoxPassword.Text; // Şifre giriş textbox'ı

            // Giriş bilgilerini doğrulama
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Başarılı giriş sonrası yapılacak işlemler (örneğin yeni bir form açma)

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
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
    }
}
