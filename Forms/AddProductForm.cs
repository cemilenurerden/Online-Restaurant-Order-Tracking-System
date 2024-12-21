using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class AddProductForm : Form
    {
        private readonly ProductRepository productRepo;
        private readonly CategoryRepository categoryRepo;
        public AddProductForm()
        {
            InitializeComponent();
            productRepo = new ProductRepository();
            categoryRepo = new CategoryRepository();
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();

        }
        private void LoadCategories()
        {
            try
            {
                var categories = categoryRepo.GetAllCategories();
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "Name";         // Kategorinin adı
                comboBoxCategory.ValueMember = "CategoryId";     // Kategorinin ID'si
                comboBoxCategory.SelectedIndex = -1;             // Varsayılan boş
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation (Boş alan kontrolü)
                if (string.IsNullOrWhiteSpace(textBoxProductName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                    comboBoxCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ürün oluştur
                var product = new Product
                {
                    Name = textBoxProductName.Text.Trim(),
                    Price = decimal.Parse(textBoxPrice.Text.Trim()),
                    CategoryId = (int)comboBoxCategory.SelectedValue
                };

                // Ürün ekle
                productRepo.AddProduct(product);

                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
            catch (FormatException)
            {
                MessageBox.Show("Fiyat alanına geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
