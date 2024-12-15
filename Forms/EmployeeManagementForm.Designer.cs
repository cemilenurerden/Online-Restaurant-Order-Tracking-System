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
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.labelSearchEmployee = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 370);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(120, 40);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Çalışan Ekle";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 303);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // EmployeeManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelSearchEmployee);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Yönetimi";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Label labelSearchEmployee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
