using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class UserDashboardForm : Form
    {
        private int userId;

        public UserDashboardForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadUserOrders();
        }

        private void LoadUserInfo()
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                User user = userRepository.GetUserById(userId);

                if (user != null)
                {
                    textBoxFirstName.Text = user.FirstName;
                    textBoxLastName.Text = user.LastName;
                    textBoxEmail.Text = user.Email;
                    textBoxPhone.Text = user.Phone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilgiler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadUserOrders()
        {
            try
            {
                OrderRepository orderRepository = new OrderRepository();
                var orders = orderRepository.GetAllOrders();

                // Kullanıcıya ait siparişleri filtrele
                var userOrders = orders.Where(o => o.userId == userId).ToList();

                // flowLayoutPanel'i temizle
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.AutoScroll = true;

                foreach (var order in userOrders)
                {
                    // Sipariş kutusu için panel oluştur
                    Panel orderPanel = new Panel
                    {
                        Width = 350,
                        Height = 150,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.WhiteSmoke
                    };

                    // Sipariş tarihini gösteren label
                    Label labelDate = new Label
                    {
                        Text = $"Tarih: {order.OrderDate:dd/MM/yyyy}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 10)
                    };

                    // Sipariş adresi
                    Label labelAddress = new Label
                    {
                        Text = $"Adres: {order.address}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 35)
                    };

                    // Ödeme yöntemi
                    Label labelPayment = new Label
                    {
                        Text = $"Ödeme: {order.paymentMethod}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 60)
                    };

                    // Sipariş durumu
                    Label labelStatus = new Label
                    {
                        Text = $"Durum: {order.status}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Location = new Point(10, 85),
                        ForeColor = Color.DarkOrange // Hazırlanıyor durumuna vurgu yapalım
                    };

                    // Panele ekle
                    orderPanel.Controls.Add(labelDate);
                    orderPanel.Controls.Add(labelAddress);
                    orderPanel.Controls.Add(labelPayment);
                    orderPanel.Controls.Add(labelStatus);

                    // FlowLayoutPanel'e ekle
                    flowLayoutPanel1.Controls.Add(orderPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Siparişler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    UserId = userId,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Email = textBoxEmail.Text,
                    Phone = textBoxPhone.Text,
                    Password = "YourPasswordHashOrEmpty", // Şifreyi burada alabilir veya değiştirmeden bırakabilirsiniz
                    Role = "user" // Rol bilgisi sabit bırakılabilir
                };

                UserRepository userRepository = new UserRepository();
                userRepository.UpdateUser(user);

                MessageBox.Show("Bilgileriniz güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilgiler güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
