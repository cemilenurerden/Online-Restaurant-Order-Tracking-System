using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM kullanicilar WHERE id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxFirstName.Text = reader.GetString("ad");
                        textBoxLastName.Text = reader.GetString("soyad");
                        textBoxEmail.Text = reader.GetString("email");
                        textBoxPhone.Text = reader.IsDBNull(reader.GetOrdinal("telefon")) ? "" : reader.GetString("telefon");
                        textBoxAddress.Text = reader.IsDBNull(reader.GetOrdinal("adres")) ? "" : reader.GetString("adres");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilgiler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUserOrders()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                        SELECT id AS 'Sipariş ID', order_date AS 'Tarih', status AS 'Durum', total_price AS 'Toplam Tutar'
                        FROM orders WHERE user_id = @UserId";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserId", userId);

                    DataTable orderTable = new DataTable();
                    adapter.Fill(orderTable);
                    dataGridViewOrders.DataSource = orderTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Siparişler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                        UPDATE kullanicilar SET ad = @FirstName, soyad = @LastName, email = @Email, 
                        telefon = @Phone, adres = @Address WHERE id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilgileriniz güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilgiler güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
