using Online_Restaurant_Order_Tracking_System.Helpers;
using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class menu : BaseForm
    {
        private Panel popupMenu;
        private readonly CategoryRepository _categoryRepository;

        public menu()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

        // Menü yüklendiğinde kategorileri dinamik olarak yükle
        private void menu_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // Dinamik kategorileri yükle
       
        // Tüm kategori butonlarının tıklama olayı
   

        // Kategori formunu aç
       


        // Dinamik olarak kategorileri veritabanından getiren metot
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private bool IsUserLoggedIn()
        {
            // Bu örnek, kullanıcı giriş durumunu kontrol etmek için bir yöntemdir.
            // Gerçek bir uygulamada, oturum bilgisini kontrol edebilirsiniz.
            return SessionManager.IsLoggedIn; // SessionManager, oturum durumunu kontrol eden bir sınıf olabilir.
        }
        private void OpenLoginForm()
        {
            Form1 profileForm = new Form1(); // Profil sayfasını aç
                                             // LoginForm loginForm = new LoginForm(); // Giriş formunu aç
            profileForm.Show();
            this.Hide(); // Mevcut formu gizle
        }
        private void OpenProfileForm()
        {
            Form1 profileForm = new Form1(); // Profil sayfasını aç
            profileForm.Show();
        }

        private void Logout()
        {
            // Çıkış işlemi
            SessionManager.IsLoggedIn = false; // Oturum durumunu kapat
            MessageBox.Show("Başarıyla çıkış yaptınız!");

            // Giriş sayfasına yönlendir
            OpenLoginForm();
        }
        private void ShowPopupMenu(PictureBox pictureBox)
        {
            // Yeni bir panel oluştur
            Panel popupMenu = new Panel
            {
                BackColor = Color.LightGray,
                Size = new Size(200, 100),
                Location = new Point(button1.Location.X - 150, button1.Location.Y + button1.Height)
            };

            // Menü seçenekleri
            Button btnProfile = new Button
            {
                Text = SessionManager.UserId.ToString(),
                Size = new Size(180, 30),
                Location = new Point(10, 10),
                BackColor = Color.White
            };
            btnProfile.Click += (s, e) => OpenProfileForm();

            Button btnLogout = new Button
            {
                Text = "Çıkış Yap",
                Size = new Size(180, 30),
                Location = new Point(10, 50),
                BackColor = Color.White
            };
            btnLogout.Click += (s, e) => Logout();

            // Menüye butonları ekle
            popupMenu.Controls.Add(btnProfile);
            popupMenu.Controls.Add(btnLogout);

            // Paneli formun üzerine ekle
            this.Controls.Add(popupMenu);
            popupMenu.BringToFront();

            this.MouseDown += Form_MouseDown;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            // Eğer popup menü varsa ve tıklama menü dışında gerçekleştiyse popup menüyü kapat
            if (popupMenu != null && !popupMenu.Bounds.Contains(this.PointToClient(MousePosition)))
            {
                this.Controls.Remove(popupMenu);
                popupMenu.Dispose();
                popupMenu = null;

                // Formun MouseDown olayını kaldır
                this.MouseDown -= Form_MouseDown;
            }
        }
        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            // Eğer popup menü varsa ve tıklama popup menü dışında gerçekleştiyse popup menüyü kapat
            if (popupMenu != null)
            {
                var globalMousePosition = PointToClient(MousePosition); // Global konumu forma göre çevir

                if (!popupMenu.Bounds.Contains(globalMousePosition)) // Global pozisyonu kontrol et
                {
                    this.Controls.Remove(popupMenu);
                    popupMenu.Dispose();
                    popupMenu = null;

                    // Olayı tekrar tetiklememek için kaldır
                    this.MouseClick -= Form_MouseClick;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı oturum durumunu kontrol et
            if (IsUserLoggedIn())
            {
                // Hover benzeri küçük pencere aç
                ShowPopupMenu(sender as PictureBox);
            }
            else
            {
                // Giriş yapılmamışsa, giriş yap sayfasına yönlendir
                OpenLoginForm();
            }
        }
    
    // Dinamik kategorileri yükle
    private void LoadCategories()
        {
            var categories = _categoryRepository.GetAllCategories(); // Repository'den kategorileri al

            foreach (var category in categories)
            {
                var button = new Button
                {
                    Text = category.Name,
                    Width = 200,
                    Height = 100,
                    BackColor = Color.LightGray,
                    ForeColor = Color.Black,
                    Tag = category.Id // Kategori ID'sini butonun Tag özelliğine ekle
                };

                // Eğer kategori resmi varsa
                //if (!string.IsNullOrEmpty(category.ImagePath))
                //{
                //    var imagePath = System.IO.Path.Combine(Application.StartupPath, "Images", category.ImagePath);
                //    if (System.IO.File.Exists(imagePath))
                //    {
                //        button.BackgroundImage = Image.FromFile(imagePath);
                //        button.BackgroundImageLayout = ImageLayout.Stretch;
                //    }
                //}

                // Butonun tıklama olayını ekle
                button.Click += ButtonCategory_Click;

                // FlowLayoutPanel'e ekle
                flowLayoutPanelCategories.Controls.Add(button);
            }
        }

        // Kategori butonuna tıklama olayı
        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int categoryId = (int)button.Tag;

                var categoryForm = new bos_dosya
                {
                    CategoryId = categoryId
                };

                categoryForm.ShowDialog();
            }
        }

        // Kategori formunu aç
        private void OpenCategoryForm(int categoryId)
        {
            // Örnek olarak boş bir form açılıyor
            MessageBox.Show($"Kategori ID: {categoryId} seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAllProducts_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                bos_dosya dosya = new bos_dosya();
                dosya.Show();
            }
        }
    }
}
