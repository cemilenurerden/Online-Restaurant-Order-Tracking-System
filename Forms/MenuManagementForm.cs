using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Models;
using System.Drawing;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class MenuManagementForm : Form
    {
        private ProductRepository _productRepository;

        public MenuManagementForm()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string searchQuery = "")
        {
            ProductRepository productRepo = new ProductRepository();
            var products = productRepo.GetAllProducts();

            if (string.IsNullOrEmpty(searchQuery))
            {
                // Tüm ürünleri getir
                products = productRepo.GetAllProducts();
            }
            else
            {
                // Arama sorgusuna göre filtrele
                products = productRepo.SearchProducts(searchQuery);
            }

            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 300,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label nameLabel = new Label
                {
                    Text = $"Ürün: {product.Name}",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                Label priceLabel = new Label
                {
                    Text = $"Fiyat: {product.Price:C}",
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                Button deleteButton = new Button
                {
                    Text = "Sil",
                    Location = new Point(200, 10),
                    BackColor = Color.Red,
                    ForeColor = Color.White
                };
                Button editButton = new Button
                {
                    Text = "Düzenle",
                    Location = new Point(200, 40),
                    BackColor = Color.LightBlue,
                    Tag = product.Id // Ürün ID'sini Tag özelliğinde tut
                };
                deleteButton.Click += (s, ev) => DeleteProduct(product.Id);

                editButton.Click += (s, e) => EditPoduct(product.Id);
                
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(deleteButton);
                productPanel.Controls.Add(editButton);

                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }

        private void EditPoduct(int id)
        {
            EditProductForm editProduct = new EditProductForm(id);
            editProduct.ShowDialog();
            LoadProducts(); // Ürün listesini yenile
               
            
        }
        private void DeleteProduct(int productId) 
        {
            if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ProductRepository productRepo = new ProductRepository();
                productRepo.DeleteProduct(productId);
                LoadProducts();
            }
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearchProduct.Text.Trim();

            // Arama sorgusunu çağır
            LoadProducts(searchQuery);
        }


            private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm(); // Yeni ürün ekleme formu
            addForm.ShowDialog();
            LoadProducts(); // 
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
        }
    }
}
