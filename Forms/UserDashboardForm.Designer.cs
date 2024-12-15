namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class UserDashboardForm
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
            this.tabControlUserDashboard = new System.Windows.Forms.TabControl();
            this.tabPageMyInfo = new System.Windows.Forms.TabPage();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tabPageMyOrders = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlUserDashboard.SuspendLayout();
            this.tabPageMyInfo.SuspendLayout();
            this.tabPageMyOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUserDashboard
            // 
            this.tabControlUserDashboard.Controls.Add(this.tabPageMyInfo);
            this.tabControlUserDashboard.Controls.Add(this.tabPageMyOrders);
            this.tabControlUserDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUserDashboard.Location = new System.Drawing.Point(0, 0);
            this.tabControlUserDashboard.Name = "tabControlUserDashboard";
            this.tabControlUserDashboard.SelectedIndex = 0;
            this.tabControlUserDashboard.Size = new System.Drawing.Size(800, 450);
            this.tabControlUserDashboard.TabIndex = 0;
            // 
            // tabPageMyInfo
            // 
            this.tabPageMyInfo.Controls.Add(this.buttonUpdateInfo);
            this.tabPageMyInfo.Controls.Add(this.textBoxPhone);
            this.tabPageMyInfo.Controls.Add(this.textBoxEmail);
            this.tabPageMyInfo.Controls.Add(this.textBoxLastName);
            this.tabPageMyInfo.Controls.Add(this.textBoxFirstName);
            this.tabPageMyInfo.Controls.Add(this.labelPhone);
            this.tabPageMyInfo.Controls.Add(this.labelEmail);
            this.tabPageMyInfo.Controls.Add(this.labelLastName);
            this.tabPageMyInfo.Controls.Add(this.labelFirstName);
            this.tabPageMyInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyInfo.Name = "tabPageMyInfo";
            this.tabPageMyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyInfo.Size = new System.Drawing.Size(792, 421);
            this.tabPageMyInfo.TabIndex = 0;
            this.tabPageMyInfo.Text = "Bilgilerim";
            this.tabPageMyInfo.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(150, 246);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(200, 40);
            this.buttonUpdateInfo.TabIndex = 10;
            this.buttonUpdateInfo.Text = "Bilgileri Güncelle";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.ButtonUpdateInfo_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(150, 170);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 120);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(150, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 20);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 22);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(50, 170);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 16);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Telefon:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(50, 120);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(50, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 16);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Soyadı:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(50, 20);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(27, 16);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Ad:";
            // 
            // tabPageMyOrders
            // 
            this.tabPageMyOrders.Controls.Add(this.flowLayoutPanel1);
            this.tabPageMyOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyOrders.Name = "tabPageMyOrders";
            this.tabPageMyOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyOrders.Size = new System.Drawing.Size(792, 421);
            this.tabPageMyOrders.TabIndex = 1;
            this.tabPageMyOrders.Text = "Siparişlerim";
            this.tabPageMyOrders.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 425);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlUserDashboard);
            this.Name = "UserDashboardForm";
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            this.tabControlUserDashboard.ResumeLayout(false);
            this.tabPageMyInfo.ResumeLayout(false);
            this.tabPageMyInfo.PerformLayout();
            this.tabPageMyOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlUserDashboard;
        private System.Windows.Forms.TabPage tabPageMyInfo;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TabPage tabPageMyOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
