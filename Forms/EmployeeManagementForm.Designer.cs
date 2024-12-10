namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class EmployeeManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.labelSearchEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 370);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(120, 40);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Çalışan Ekle";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(150, 370);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(120, 40);
            this.buttonDeleteEmployee.TabIndex = 2;
            this.buttonDeleteEmployee.Text = "Çalışan Sil";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(550, 15);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchEmployee.TabIndex = 3;
            // 
            // labelSearchEmployee
            // 
            this.labelSearchEmployee.AutoSize = true;
            this.labelSearchEmployee.Location = new System.Drawing.Point(450, 18);
            this.labelSearchEmployee.Name = "labelSearchEmployee";
            this.labelSearchEmployee.Size = new System.Drawing.Size(79, 16);
            this.labelSearchEmployee.TabIndex = 4;
            this.labelSearchEmployee.Text = "Çalışan Ara:";
            // 
            // EmployeeManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.labelSearchEmployee);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Yönetimi";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Label labelSearchEmployee;
    }
}
