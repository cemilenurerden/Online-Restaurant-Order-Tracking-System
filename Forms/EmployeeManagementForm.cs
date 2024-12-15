using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq; // LINQ kütüphanesi eklenmeli

using Online_Restaurant_Order_Tracking_System.Models;
using Online_Restaurant_Order_Tracking_System.Repositories;
using Online_Restaurant_Order_Tracking_System.Helpers;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class EmployeeManagementForm : Form
    {
        private readonly UserRepository userRepository;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            flowLayoutPanel1.Controls.Clear();

            List<User> employees = userRepository.GetAllUsers().Where(u => u.Role == "worker").ToList();

            foreach (var emp in employees)
            {
                Panel employeePanel = new Panel
                {
                    Width = 200,
                    Height = 120,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label nameLabel = new Label
                {
                    Text = $"{emp.FirstName} {emp.LastName}",
                    AutoSize = false,
                    Width = 180,
                    Height = 25,
                    Location = new Point(10, 10)
                };

                Label emailLabel = new Label
                {
                    Text = $"Email: {emp.Email}",
                    AutoSize = false,
                    Width = 180,
                    Height = 25,
                    Location = new Point(10, 40)
                };

                Button deleteButton = new Button
                {
                    Text = "Sil",
                    BackColor = Color.OrangeRed,
                    ForeColor = Color.White,
                    Location = new Point(10, 70),
                    Width = 80,
                    Height = 30
                };

                deleteButton.Click += (s, ev) => DeleteEmployee(emp.UserId);

                employeePanel.Controls.Add(nameLabel);
                employeePanel.Controls.Add(emailLabel);
                employeePanel.Controls.Add(deleteButton);

                flowLayoutPanel1.Controls.Add(employeePanel);
            }
        }
        private void DeleteEmployee(int userId)
        {
            if (SessionManager.UserRole != "admin")
            {
                MessageBox.Show("Sadece admin kullanıcılar çalışan silebilir!", "Yetkisiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bu çalışanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userRepository.DeleteUser(userId);
                MessageBox.Show("Çalışan başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees(); // Listeyi yenile
            }
        }
       

        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserRole != "admin")
            {
                MessageBox.Show("Sadece admin kullanıcılar çalışan ekleyebilir!", "Yetkisiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.ShowDialog();
            LoadEmployees(); // Listeyi yenile
        }

        private void TextBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchEmployee.Text.ToLower();
            var filteredEmployees = userRepository.GetAllUsers()
                .Where(u => u.Role == "worker" &&
                            (u.FirstName.ToLower().Contains(searchTerm) ||
                             u.LastName.ToLower().Contains(searchTerm) ||
                             u.Email.ToLower().Contains(searchTerm)))
                .ToList();

            DisplayFilteredEmployees(filteredEmployees);
        }

        private void DisplayFilteredEmployees(List<User> employees)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var emp in employees)
            {
                Panel employeePanel = new Panel
                {
                    Width = 200,
                    Height = 120,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label nameLabel = new Label
                {
                    Text = $"{emp.FirstName} {emp.LastName}",
                    AutoSize = false,
                    Width = 180,
                    Height = 25,
                    Location = new Point(10, 10)
                };

                Label emailLabel = new Label
                {
                    Text = $"Email: {emp.Email}",
                    AutoSize = false,
                    Width = 180,
                    Height = 25,
                    Location = new Point(10, 40)
                };

                employeePanel.Controls.Add(nameLabel);
                employeePanel.Controls.Add(emailLabel);

                flowLayoutPanel1.Controls.Add(employeePanel);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            LoadEmployees();
        }
    }
}
