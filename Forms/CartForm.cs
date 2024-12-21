using System;
using System.Drawing;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Helpers;
using Online_Restaurant_Order_Tracking_System.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            var cart = CartManager.Instance.Cart;
            flowLayoutPanelCart.Controls.Clear();
            flowLayoutPanelCart.AutoScroll = true; // Scroll bar aktif

            foreach (var item in cart)
            {
                // Ürün paneli
                Panel itemPanel = new Panel
                {
                    Width = flowLayoutPanelCart.Width - 30,
                    Height = 120,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Ürün resmi
                PictureBox productImage = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    ImageLocation = "path_to_your_images_folder/" + item.ProductId + ".jpg",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10)
                };

                // Ürün ismi ve detayları
                Label productLabel = new Label
                {
                    Text = $"{item.ProductName}\nAdet: {item.Quantity} x {item.Price:C}",
                    AutoSize = false,
                    Width = itemPanel.Width - 230,
                    Height = 100,
                    Location = new Point(120, 10),
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                // Azalt butonu
                Button btnDecrease = new Button
                {
                    Text = "-",
                    Width = 30,
                    Height = 30,
                    Location = new Point(itemPanel.Width - 100, 10)
                };
                btnDecrease.Click += (s, e) => UpdateQuantity(item.ProductId, -1);

                // Artır butonu
                Button btnIncrease = new Button
                {
                    Text = "+",
                    Width = 30,
                    Height = 30,
                    Location = new Point(itemPanel.Width - 60, 10)
                };
                btnIncrease.Click += (s, e) => UpdateQuantity(item.ProductId, 1);

                // Sil butonu
                Button btnRemove = new Button
                {
                    Text = "Sil",
                    Width = 60,
                    Height = 30,
                    Location = new Point(itemPanel.Width - 100, 50),
                    BackColor = Color.Red,
                    ForeColor = Color.White
                };
                btnRemove.Click += (s, e) => RemoveFromCart(item.ProductId);

                // Panele kontrolleri ekle
                itemPanel.Controls.Add(productImage);
                itemPanel.Controls.Add(productLabel);
                itemPanel.Controls.Add(btnDecrease);
                itemPanel.Controls.Add(btnIncrease);
                itemPanel.Controls.Add(btnRemove);

                flowLayoutPanelCart.Controls.Add(itemPanel);
            }

            decimal totalPrice = CalculateTotalPrice();
            labelTotalPrice.Text = $"Toplam: {totalPrice:C}";
        }

        private void UpdateQuantity(int productId, int change)
        {
            var cart = CartManager.Instance.Cart;
            var item = cart.Find(x => x.ProductId == productId);

            if (item != null)
            {
                item.Quantity += change;

                // Miktar sıfır veya negatifse ürünü sepetten kaldır
                if (item.Quantity <= 0)
                {
                    cart.Remove(item);
                }
            }

            LoadCartItems(); // Sepeti yeniden yükle
        }
        private void RemoveFromCart(int productId)
        {
            var cart = CartManager.Instance.Cart;
            var item = cart.Find(x => x.ProductId == productId);

            if (item != null)
            {
                cart.Remove(item);
            }

            LoadCartItems(); // Sepeti yeniden yükle
        }



        private decimal CalculateTotalPrice()
        {
            var cart = CartManager.Instance.Cart;
            decimal total = 0;
            foreach (var item in cart)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            var cart = CartManager.Instance.Cart;

            if (cart.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş, lütfen ürün ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                OrderRepository orderRepository = new OrderRepository();
                int userId = SessionManager.UserId; // Kullanıcının ID'si
                string address = textBoxAddress.Text; // Adres bilgisi
                string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString(); // Ödeme yöntemi

                // Sepet verilerini gönder
                orderRepository.AddOrder(userId, address, paymentMethod, cart);

                MessageBox.Show("Sipariş başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sepeti temizle
                CartManager.Instance.Cart.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonContinueShopping_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCardSelected = comboBoxPaymentMethod.SelectedItem.ToString() == "Kredi Kartı";
            labelCardName.Visible = isCardSelected;
            textBoxCardName.Visible = isCardSelected;
            labelCardNumber.Visible = isCardSelected;
            textBoxCardNumber.Visible = isCardSelected;
        }

        private void flowLayoutPanelCart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
