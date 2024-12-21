using System;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void ButtonEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm employeeForm = new EmployeeManagementForm();
            employeeForm.Show();
            this.Hide();
        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
            MenuManagementForm productForm = new MenuManagementForm();
            productForm.Show();
            this.Hide();
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // Çıkış işlemleri
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {

        }
    }
}
