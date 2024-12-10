using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using ProjeAdi.Repositories;
using System.Drawing;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class DailyReportForm : Form
    {
        private DataTable dailyOrdersTable;

        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            LoadDailyOrders();
        }

        private void LoadDailyOrders()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                        SELECT id, customer_name, order_date, status, total_price 
                        FROM orders 
                        WHERE DATE(order_date) = CURDATE()";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    dailyOrdersTable = new DataTable();
                    adapter.Fill(dailyOrdersTable);

                    dataGridViewDailyOrders.DataSource = dailyOrdersTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonPrintReport_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 20;
            Font font = new Font("Arial", 10);

            e.Graphics.DrawString("Günlük Sipariş Raporu", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 20, y);
            y += 40;

            foreach (DataRow row in dailyOrdersTable.Rows)
            {
                string line = $"ID: {row["id"]}, Müşteri: {row["customer_name"]}, " +
                              $"Tarih: {row["order_date"]}, Durum: {row["status"]}, " +
                              $"Toplam: {row["total_price"]:C}";
                e.Graphics.DrawString(line, font, Brushes.Black, 20, y);
                y += 20;
            }
        }
    }
}
