using System;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Models;
using System.Collections.Generic;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class EditProductForm : Form
    {
        private readonly int ProductId;
        private readonly ProductRepository _productRepository;

        public EditProductForm(int productId)
        {
            InitializeComponent();
            ProductId = productId;
            _productRepository = new ProductRepository();
            LoadCategories();
            LoadProductDetails();
        }
        private void LoadCategories()
        {
            var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.GetAllCategories();

            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private void LoadProductDetails()
        {
            Product product = _productRepository.GetProductById(ProductId);

            if (product != null)
            {
                textBoxProductName.Text = product.Name;
                textBoxPrice.Text = product.Price.ToString();
                textBox1.Text = product.description;
                comboBoxCategory.SelectedValue = product.CategoryId;
            }
        }

            private void EditProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                var product = _productRepository.GetProductById(ProductId);
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadCategories(int selectedCategoryId)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Id = ProductId,
                    Name = textBoxProductName.Text,
                    Price = decimal.Parse(textBoxPrice.Text),
                    ImagePath = "ldldl"
                };

                _productRepository.UpdateProduct(product);
                MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
