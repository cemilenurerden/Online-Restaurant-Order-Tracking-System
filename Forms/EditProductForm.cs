using System;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Models;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class EditProductForm : Form
    {
        private readonly int _productId;
        private readonly ProductRepository _productRepository;

        public EditProductForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
            _productRepository = new ProductRepository();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                var product = _productRepository.GetProductById(_productId);
               
               
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
                    Id = _productId,
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
