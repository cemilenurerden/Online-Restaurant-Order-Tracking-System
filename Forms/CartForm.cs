using System;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Helpers;
using Online_Restaurant_Order_Tracking_System.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class CartForm : BaseForm
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

            foreach (var item in cart)
            {
                Label productLabel = new Label
                {
                    Text = $"{item.ProductName} - {item.Quantity} x {item.Price:C}",
                    AutoSize = true
                };

                flowLayoutPanelCart.Controls.Add(productLabel);
            }

            decimal totalPrice = CalculateTotalPrice();
            labelTotalPrice.Text = $"Toplam: {totalPrice:C}";
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
                int userId = GetCurrentUserId(); // Giriş yapan kullanıcının ID'sini alın (kendi yönteminizle)
                int orderDate = 9;

                foreach (var item in cart)
                {
                    // Her ürünü veritabanına ekle
                    orderRepository.AddOrder(userId, item.ProductId, item.Quantity, orderDate);
                }

                MessageBox.Show("Sipariş başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sepeti temizle
                CartManager.Instance.Cart.Clear();

                // Formu kapat
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private int GetCurrentUserId()
        {
            // Bu yöntem, oturumdaki kullanıcının ID'sini döndürmelidir.
            // Örnek olarak, sabit bir ID dönebilir:
            return 1; // Test için sabit kullanıcı ID'si
        }

        private void buttonContinueShopping_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCardSelected = comboBoxPaymentMethod.SelectedItem.ToString() == "Kredi Kartı";
            labelCardName.Visible = isCardSelected;
            textBoxCardName.Visible = isCardSelected;
            labelCardNumber.Visible = isCardSelected;
            textBoxCardNumber.Visible = isCardSelected;
        }
    }
}
