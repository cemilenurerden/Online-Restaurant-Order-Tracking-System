using System;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class EmployeeHomePage : Form
    {
        public EmployeeHomePage()
        {
            InitializeComponent();
        }

        private void ButtonOrderStatus_Click(object sender, EventArgs e)
        {
            OrderStatusForm orderStatusForm = new OrderStatusForm();
            orderStatusForm.Show();
            this.Hide();
        }

        private void ButtonDailyReport_Click(object sender, EventArgs e)
        {
            DailyReportForm dailyReportForm = new DailyReportForm();
            dailyReportForm.Show();
            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // Çıkış işlemleri
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void EmployeeHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
