using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Models;

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
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            try
            {
                var products = _productRepository.GetAllProducts();
                dataGridViewMenu.DataSource = products;
                dataGridViewMenu.Columns["ProductId"].Visible = false; // ID sütununu gizle
                dataGridViewMenu.Columns["CategoryId"].HeaderText = "Kategori";
                dataGridViewMenu.Columns["ProductName"].HeaderText = "Ürün Adı";
                dataGridViewMenu.Columns["Price"].HeaderText = "Fiyat";
                dataGridViewMenu.Columns["Stock"].HeaderText = "Stok";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Menü yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearchProduct.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                try
                {
                    var filteredProducts = _productRepository.SearchProducts(keyword);
                    dataGridViewMenu.DataSource = filteredProducts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LoadMenuItems();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            using (var addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMenuItems();
                }
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ProductId"].Value;

                using (var editProductForm = new EditProductForm(productId))
                {
                    if (editProductForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMenuItems();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ProductId"].Value;

                var confirmResult = MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _productRepository.DeleteProduct(productId);
                        MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMenuItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
