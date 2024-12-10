using System;
using System.Windows.Forms;
using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class EmployeeManagementForm : Form
    {
        private readonly UserRepository _employeeRepository;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            _employeeRepository = new UserRepository();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            var employees = _employeeRepository.GetAllEmployees();
            dataGridViewEmployees.DataSource = employees;
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            using (var addEmployeeForm = new AddEmployeeForm())
            {
                if (addEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    _employeeRepository.AddEmployee(addEmployeeForm.Employee);
                    LoadEmployeeData();
                }
            }
        }

        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir çalışan seçin.");
                return;
            }

            var employeeId = (int)dataGridViewEmployees.CurrentRow.Cells["EmployeeId"].Value;
            _employeeRepository.DeleteEmployee(employeeId);
            LoadEmployeeData();
        }

        private void TextBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = textBoxSearchEmployee.Text.Trim();
            dataGridViewEmployees.DataSource = _employeeRepository.SearchEmployees(searchQuery);
        }
    }
}
