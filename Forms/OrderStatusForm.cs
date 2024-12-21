using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class OrderStatusForm : Form
    {
        private DataTable ordersTable;

        public OrderStatusForm()
        {
            InitializeComponent();
        }

        private void OrderStatusForm_Load(object sender, EventArgs e)
        {
            LoadOrdersFromDatabase();
        }

        private void LoadOrdersFromDatabase()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT id, customer_name, status FROM orders";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    ordersTable = new DataTable();
                    adapter.Fill(ordersTable);

                    // DataGridView'e verileri bağla
                    dataGridViewOrders.DataSource = ordersTable;

                    // Durum sütununu ComboBox olarak ayarla
                    var statusColumn = new DataGridViewComboBoxColumn
                    {
                        DataSource = new[] { "Hazırlanıyor", "Kargoya Verildi", "Teslim Edildi" },
                        DataPropertyName = "status",
                        HeaderText = "Sipariş Durumu",
                        Name = "OrderStatusColumn"
                    };

                    dataGridViewOrders.Columns.Remove("status");
                    dataGridViewOrders.Columns.Add(statusColumn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateStatus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.IsNewRow) continue;

                int orderId = Convert.ToInt32(row.Cells["id"].Value);
                string newStatus = row.Cells["OrderStatusColumn"].Value.ToString();

                UpdateOrderStatus(orderId, newStatus);
            }

            MessageBox.Show("Sipariş durumları başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "UPDATE orders SET status = @status WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@status", newStatus);
                    command.Parameters.AddWithValue("@id", orderId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
