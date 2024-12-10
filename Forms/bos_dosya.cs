using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Helpers;
using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class bos_dosya : BaseForm
    {
        private readonly ProductRepository repository;
        public bos_dosya()
        {
            InitializeComponent();
            repository = new ProductRepository();

        }
        private void bos_dosya_Load(object sender, EventArgs e)
        {
            List<Product> products = repository.GetAllProducts();
            LoadProductsToPanel(products);
        }

        private void LoadProductsToPanel(List<Product> products)
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelProducts.AutoScroll = true; // Kaydırma çubuğunu etkinleştir
           
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 250,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox productImage = new PictureBox
                {
                    Width = 180,
                    Height = 120,
                    ImageLocation = product.ImagePath, // Ürünün görsel yolu
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top
                };

                Label productName = new Label
                {
                    Text = product.Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
                };

                Label productPrice = new Label
                {
                    Text = $"Fiyat: {product.Price:C}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Arial", 10)
                };

                Button addToCartButton = new Button
                {
                    Text = "Sepete Ekle",
                    Dock = DockStyle.Bottom,
                    BackColor = System.Drawing.Color.Orange,
                    Height = 40
                };
                addToCartButton.Click += (s, ev) => AddToCart(product);

                productPanel.Controls.Add(addToCartButton);
                productPanel.Controls.Add(productPrice);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(productImage);

                flowLayoutPanelProducts.Controls.Add(productPanel);
            }
        }

        private void AddToCart(Product product)
        {
            var cart = CartManager.Instance.Cart;

            var existingItem = cart.Find(item => item.ProductId == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    Quantity = 1
                });
            }

            MessageBox.Show($"{product.Name} sepete eklendi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm(); // Sepet formunu aç
            cartForm.ShowDialog();

        }
    }
}
