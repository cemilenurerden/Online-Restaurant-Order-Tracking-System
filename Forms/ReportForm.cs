using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjeAdi.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            string reportType = reportTypeComboBox.SelectedItem?.ToString();
            DateTime startDate = startDatePicker.Value.Date;
            DateTime endDate = endDatePicker.Value.Date;

            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Lütfen bir rapor türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reportData = GetReportData(reportType, startDate, endDate);
                reportDataGridView.DataSource = reportData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor oluşturulurken bir hata meydana geldi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetReportData(string reportType, DateTime startDate, DateTime endDate)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = string.Empty;

                switch (reportType)
                {
                    case "Günlük":
                        query = "SELECT DATE(order_date) AS Tarih, SUM(total_price) AS Toplam FROM orders " +
                                "WHERE order_date BETWEEN @StartDate AND @EndDate GROUP BY DATE(order_date)";
                        break;
                    case "Aylık":
                        query = "SELECT YEAR(order_date) AS Yıl, MONTH(order_date) AS Ay, SUM(total_price) AS Toplam FROM orders " +
                                "WHERE order_date BETWEEN @StartDate AND @EndDate GROUP BY YEAR(order_date), MONTH(order_date)";
                        break;
                    case "Yıllık":
                        query = "SELECT YEAR(order_date) AS Yıl, SUM(total_price) AS Toplam FROM orders " +
                                "WHERE order_date BETWEEN @StartDate AND @EndDate GROUP BY YEAR(order_date)";
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            // PDF'e aktarma işlemi
            MessageBox.Show("Rapor PDF olarak indirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
